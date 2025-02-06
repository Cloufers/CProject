using cafe.Data;
using cafe.Logging;

namespace cafe
{
    public partial class AdminPanel : Form
    {
        private Database _database;
        public AdminPanel()
        {
            InitializeComponent();
            DatabaseConnection();
        }

        private void DatabaseConnection()
        {
            string connectionString = "Host=ep-fragrant-shadow-a2mncv4x-pooler.eu-central-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_DXn7qEayl1Yz";
            _database = new Database(connectionString);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void nightbuttonViewReservationForToday_Click(object sender, EventArgs e)
        {
            LoadReservationsForDate(DateTime.Today);
        }

        private void LoadReservationsForDate(DateTime date)
        {
            try
            {
                var reservations = _database.GetReservationsByDate(date);
                dataGridViewReservations.DataSource = reservations;
                labelStatus.Text = $"Показаны резервации на {date.ToShortDateString()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке резерваций: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nightbuttonViewSelectedDateReservations_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = poisondateTimePicker.Value.Date; // Получаем выбранную дату
            LoadReservationsForDate(selectedDate);
        }

        private void buttonCompleteReservation_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите резервацию для завершения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reservationId = Convert.ToInt32(dataGridViewReservations.SelectedRows[0].Cells["ID"].Value);
            try
            {
                if (_database.CompleteReservation(reservationId))
                {
                    MessageBox.Show("Резервация успешно завершена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadReservationsForDate(DateTime.Today); // Обновляем список
                }
                else
                {
                    MessageBox.Show("Не удалось завершить резервацию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Ошибка при завершении резервации: " + ex.Message);
                Logger.LogError("Стек вызовов: " + ex.StackTrace);
                MessageBox.Show("Ошибка при завершении резервации: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelReservation_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите резервацию для отмены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reservationId = Convert.ToInt32(dataGridViewReservations.SelectedRows[0].Cells["ID"].Value);

            try
            {
                if (_database.CancelReservation(reservationId))
                {
                    MessageBox.Show("Резервация успешно отменена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadReservationsForDate(DateTime.Today); // Обновляем список
                }
                else
                {
                    MessageBox.Show("Не удалось отменить резервацию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отмене резервации: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
