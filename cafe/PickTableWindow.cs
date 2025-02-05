using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace cafe
{
    public partial class PickTableWindow : Form
    {
        private Database _database;
        private Dictionary<Button, int> _tableMapping = new Dictionary<Button, int>();
        private DateTime _selectedDate = DateTime.Today;
        private TimeSpan _selectedTime = new TimeSpan(10, 0, 0); 

        public PickTableWindow()
        {
            InitializeComponent();
            DatabaseConnection();
            InitializeTableMapping();
            InitializeTimeSlots();
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            comboBoxTime.SelectedIndexChanged += ComboBoxTime_SelectedIndexChanged;
            AddClickHandlers();
            RefreshTableColors();
            InitializeForm();
        }

        private void InitializeForm()
        {
            ClientSize = new Size(622, 804);
        }

        private void DatabaseConnection()
        {
            string connectionString = "Host=ep-fragrant-shadow-a2mncv4x-pooler.eu-central-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_DXn7qEayl1Yz";
            _database = new Database(connectionString);
        }

        private void InitializeTableMapping()
        {
            _tableMapping = new Dictionary<Button, int>
            {
                { sideTable1, 1 },
                { sideTable2, 2 },
                { sideTable3, 3 },
                { sideTable4, 4 },
                { middleTable1, 5 },
                { middleTable2, 6 },
                { middleTable3, 7 },
                { middleTable4, 8 },
                { middleTable5, 9 },
                { middleTable6, 10 },
                { middleTable7, 11 },
                { middleTable8, 12 },
                { middleTable9, 13 },
                { middleTable10, 14 },
                { angledTable1, 15 },
                { angledTable2, 16 },
                { angledTable3, 17 }
            };
        }

        private void InitializeTimeSlots()
        {
            comboBoxTime.Items.Clear();

            TimeSpan startTime = new TimeSpan(10, 0, 0); // Начало в 10:00
            TimeSpan endTime = new TimeSpan(14, 0, 0);   // Конец в 14:00
            TimeSpan slotDuration = new TimeSpan(1, 0, 0); // Шаг 1 час

            // Генерируем временные слоты как TimeSpan
            for (TimeSpan ts = startTime; ts < endTime; ts += slotDuration)
            {
                // Форматируем TimeSpan в строку "HH:mm"
                string timeString = ts.ToString(@"hh\:mm");
                comboBoxTime.Items.Add(timeString);
            }

            if (comboBoxTime.Items.Count > 0)
            {
                comboBoxTime.SelectedIndex = 0;
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _selectedDate = dateTimePicker1.Value.Date;
            RefreshTableColors();
        }

        private void ComboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTime.SelectedItem != null)
            {
                try
                {
                    string timeString = comboBoxTime.SelectedItem.ToString().Trim();

                    // Парсим через DateTime для большей гибкости
                    DateTime parsedTime = DateTime.ParseExact(
                        timeString,
                        "HH:mm",
                        System.Globalization.CultureInfo.InvariantCulture
                    );

                    _selectedTime = parsedTime.TimeOfDay;
                    RefreshTableColors();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Некорректное время: {ex.Message}");
                    _selectedTime = new TimeSpan(10, 0, 0);
                }
            }
        }

        private void RefreshTableColors()
        {
            var tables = _database.GetTables();
            if (tables == null || !tables.Any())
            {
                MessageBox.Show("Нет данных о столах.");
                return;
            }

            foreach (var pair in _tableMapping)
            {
                if (pair.Key == null)
                {
                    Console.WriteLine($"Кнопка с ID={pair.Value} не найдена.");
                    continue;
                }

                var table = tables.FirstOrDefault(t => t.ID == pair.Value);
                if (table == null)
                {
                    Console.WriteLine($"Стол с ID={pair.Value} не найден в базе.");
                    continue;
                }

                bool isAvailable = IsTableAvailable(pair.Value, _selectedDate, _selectedTime);
                pair.Key.BackColor = isAvailable ? Color.Green : Color.Red;
            }
        }

        private bool IsTableAvailable(int tableID, DateTime date, TimeSpan time)
        {
            var reservedTimes = _database.GetReservedTimes(tableID, date);
            TimeSpan duration = new TimeSpan(2, 0, 0); // Продолжительность бронирования 2 часа
            DateTime reservationStartTime = date + time;
            DateTime reservationEndTime = reservationStartTime + duration;

            foreach (var reservedTime in reservedTimes)
            {
                DateTime reservedEndTime = reservedTime + duration;
                if (reservationStartTime < reservedEndTime && reservationEndTime > reservedTime)
                {
                    return false;
                }
            }

            return true;
        }

        private void AddClickHandlers()
        {
            foreach (var pair in _tableMapping)
            {
                pair.Key.Click += (sender, e) =>
                {
                    if (pair.Key.BackColor == Color.Green)
                    {
                        var form2 = new ReserveTableWindow(pair.Value, _selectedDate, _selectedTime);
                        form2.ReservationCompleted += () =>
                        {
                            _database.UpdateTableStatus(pair.Value, TableStatus.Reserved);
                            RefreshTableColors();
                        };
                        form2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Стол уже занят на выбранное время!");
                    }
                };
            }
        }

        
    }
}