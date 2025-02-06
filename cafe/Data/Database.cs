using cafe.Core;
using cafe.Logging;
using Npgsql;
using System;
using System.Collections.Generic;

namespace cafe.Data
{
    public class Database
    {
        private readonly string _connectionString;

        public Database(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Метод для добавления бронирования
        public bool AddReservation(string name, string phone, string email, DateTime reservationDateTime, int tableID, int numberOfPeople)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();

                    // Добавляем клиента
                    var insertClientQuery = "INSERT INTO Clients (Name, Phone, Email) VALUES (@name, @phone, @email) RETURNING ID;";
                    using (var cmd = new NpgsqlCommand(insertClientQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("phone", string.IsNullOrEmpty(phone) ? DBNull.Value : phone);
                        cmd.Parameters.AddWithValue("email", string.IsNullOrEmpty(email) ? DBNull.Value : email);

                        var clientID = (int)cmd.ExecuteScalar(); // Получаем ID добавленного клиента

                        // Добавляем бронирование
                        var insertReservationQuery = @"
                    INSERT INTO Reservations (TableID, ClientID, ReservationDateTime, Duration, Status)
                    VALUES (@tableID, @clientID, @reservationDateTime, @duration, @status);";

                        using (var reservationCmd = new NpgsqlCommand(insertReservationQuery, conn))
                        {
                            reservationCmd.Parameters.AddWithValue("tableID", tableID);
                            reservationCmd.Parameters.AddWithValue("clientID", clientID);
                            reservationCmd.Parameters.AddWithValue("reservationDateTime", reservationDateTime);
                            reservationCmd.Parameters.AddWithValue("duration", TimeSpan.FromHours(2)); // Пример: бронирование на 2 часа
                            reservationCmd.Parameters.AddWithValue("status", "активно");

                            reservationCmd.ExecuteNonQuery();
                        }
                    }
                }

                Console.WriteLine("Бронирование успешно добавлено!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при добавлении бронирования: " + ex.Message);
                return false;
            }
        }

        public List<DateTime> GetReservedTimes(int tableID, DateTime date)
        {
            var reservedTimes = new List<DateTime>();
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    var query = @"
                SELECT ReservationDateTime
                FROM Reservations
                WHERE TableID = @tableID
                  AND DATE(ReservationDateTime) = @date
                  AND Status = 'активно';";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("tableID", tableID);
                        cmd.Parameters.AddWithValue("date", date.Date);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                reservedTimes.Add(reader.GetDateTime(0));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при получении забронированных временных слотов: " + ex.Message);
                Console.WriteLine("Стек вызовов: " + ex.StackTrace);
            }
            return reservedTimes;
        }

        public List<TableInfo> GetTables()
        {
            var tables = new List<TableInfo>();
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    var query = "SELECT ID, TableNumber, Status FROM Tables;";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tables.Add(new TableInfo
                            {
                                ID = reader.GetInt32(0),
                                TableNumber = reader.GetInt32(1),
                                Status = reader.GetString(2) == "свободен"
                                    ? TableStatus.Free
                                    : TableStatus.Reserved
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки столов: {ex.Message}");
            }
            return tables;
        }

        public void UpdateTableStatus(int tableId, TableStatus status)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var query = "UPDATE Tables SET Status = @status WHERE ID = @id;";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("status", status == TableStatus.Free ? "свободен" : "занят");
                    cmd.Parameters.AddWithValue("id", tableId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private byte[] GeneratePasswordHash(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                return sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public void AddAdmin(string username, string password, string role)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    var passwordHash = GeneratePasswordHash(password);
                    var query = "INSERT INTO employees (username, password_hash, role) VALUES (@username, @password_hash, @role);";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password_hash", passwordHash);
                        cmd.Parameters.AddWithValue("role", role);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при добавлении администратора: " + ex.Message);
            }
        }

        public bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    var passwordHash = GeneratePasswordHash(password);
                    var query = "SELECT role FROM employees WHERE username = @username AND password_hash = @password_hash;";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password_hash", passwordHash);
                        var result = cmd.ExecuteScalar();
                        return result != null; // Проверяем, что пользователь найден
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при аутентификации пользователя: " + ex.Message);
                return false;
            }
        }

        public List<Reservation> GetReservationsByDate(DateTime date)
        {
            var reservations = new List<Reservation>();
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    var query = @"
                SELECT r.ID, c.Name, c.Phone, c.Email, r.TableID, r.ReservationDateTime, r.Duration, r.Status
                FROM Reservations r
                JOIN Clients c ON r.ClientID = c.ID
                WHERE DATE(r.ReservationDateTime) = @date;";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("date", date.Date);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                reservations.Add(new Reservation
                                {
                                    ID = reader.GetInt32(0),
                                    ClientName = reader.GetString(1),
                                    ClientPhone = reader.IsDBNull(2) ? null : reader.GetString(2),
                                    ClientEmail = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    TableID = reader.GetInt32(4),
                                    ReservationDateTime = reader.GetDateTime(5),
                                    Duration = reader.GetTimeSpan(6),
                                    Status = reader.GetString(7)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при получении резерваций: " + ex.Message);
            }
            return reservations;
        }

        public bool CompleteReservation(int reservationId)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();

                    // Шаг 1: Получаем данные о бронировании
                    var queryGetReservation = @"
                SELECT r.ClientID, r.TableID, r.ReservationDateTime, r.Duration
                FROM Reservations r
                WHERE r.ID = @id;";
                    int clientId, tableId;
                    DateTime reservationDateTime;
                    TimeSpan duration;

                    using (var cmdGet = new NpgsqlCommand(queryGetReservation, conn))
                    {
                        cmdGet.Parameters.AddWithValue("id", reservationId);
                        using (var reader = cmdGet.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                Logger.LogError($"Бронирование с ID {reservationId} не найдено.");
                                return false; // Бронирование не найдено
                            }

                            clientId = reader.GetInt32(0);
                            tableId = reader.GetInt32(1);
                            reservationDateTime = reader.GetDateTime(2);
                            duration = reader.GetTimeSpan(3);

                            Logger.LogInfo($"Найдено бронирование: ClientID={clientId}, TableID={tableId}, ReservationDateTime={reservationDateTime}, Duration={duration}");
                        } // reader закрыт здесь
                    }

                    // Шаг 2: Проверяем существование клиента
                    var queryCheckClient = "SELECT COUNT(*) FROM clients WHERE id = @clientId;";
                    using (var cmdCheckClient = new NpgsqlCommand(queryCheckClient, conn))
                    {
                        cmdCheckClient.Parameters.AddWithValue("clientId", clientId);
                        int clientCount = Convert.ToInt32(cmdCheckClient.ExecuteScalar());
                        if (clientCount == 0)
                        {
                            Logger.LogError($"Клиент с ID {clientId} не найден.");
                            return false; // Клиент не найден
                        }
                    }

                    // Шаг 3: Проверяем существование столика
                    var queryCheckTable = "SELECT COUNT(*) FROM tables WHERE id = @tableId;";
                    using (var cmdCheckTable = new NpgsqlCommand(queryCheckTable, conn))
                    {
                        cmdCheckTable.Parameters.AddWithValue("tableId", tableId);
                        int tableCount = Convert.ToInt32(cmdCheckTable.ExecuteScalar());
                        if (tableCount == 0)
                        {
                            Logger.LogError($"Столик с ID {tableId} не найден.");
                            return false; // Столик не найден
                        }
                    }

                    // Шаг 4: Добавляем запись в successfulReservations
                    var queryInsert = @"
                INSERT INTO successfulReservations (client_id, table_id, reservation_datetime, duration)
                VALUES (@clientId, @tableId, @reservationDateTime, @duration);";
                    using (var cmdInsert = new NpgsqlCommand(queryInsert, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("clientId", clientId);
                        cmdInsert.Parameters.AddWithValue("tableId", tableId);
                        cmdInsert.Parameters.AddWithValue("reservationDateTime", reservationDateTime);
                        cmdInsert.Parameters.AddWithValue("duration", duration);
                        cmdInsert.ExecuteNonQuery();
                        Logger.LogInfo("Запись успешно добавлена в successfulReservations.");
                    }

                    // Шаг 5: Удаляем запись из Reservations
                    var queryDelete = "DELETE FROM Reservations WHERE ID = @id;";
                    using (var cmdDelete = new NpgsqlCommand(queryDelete, conn))
                    {
                        cmdDelete.Parameters.AddWithValue("id", reservationId);
                        cmdDelete.ExecuteNonQuery();
                        Logger.LogInfo("Запись успешно удалена из Reservations.");
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Ошибка при завершении резервации: " + ex.Message);
                Logger.LogError("Стек вызовов: " + ex.StackTrace);
                return false;
            }
        }


        public bool CancelReservation(int reservationId)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    var query = "DELETE FROM Reservations WHERE ID = @id;";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("id", reservationId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при отмене резервации: " + ex.Message);
                return false;
            }
        }

        public int ExecuteNonQuery(string query, NpgsqlParameter[] parameters)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public object ExecuteScalar(string query, NpgsqlParameter[] parameters)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}