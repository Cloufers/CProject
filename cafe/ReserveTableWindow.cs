using System;
using System.Windows.Forms;

namespace cafe
{
    public partial class ReserveTableWindow : Form
    {
        private Database _database;
        public event Action ReservationCompleted;
        private int _tableID;
        private DateTime _selectedDate;
        private TimeSpan _selectedTime;

        public ReserveTableWindow(int tableID, DateTime selectedDate, TimeSpan selectedTime)
        {
            InitializeComponent();
            _tableID = tableID;
            _selectedDate = selectedDate;
            _selectedTime = selectedTime;
            SetupDatabase();
            InitializeForm();
            ClientSize = new Size(594, 539);
        }

        public ReserveTableWindow()
        {
            InitializeComponent();
            SetupDatabase();
            InitializeForm();
        }

        private void SetupDatabase()
        {
            string connectionString = "Host=ep-fragrant-shadow-a2mncv4x-pooler.eu-central-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_DXn7qEayl1Yz";
            _database = new Database(connectionString);
        }

        private void InitializeForm()
        {
            ClientSize = new Size(400, 300);
            dateTimePicker1.Value = _selectedDate;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Enabled = false; // Запрещаем изменение даты

            comboBoxTime.Items.Clear();
            comboBoxTime.Items.Add(_selectedTime.ToString(@"hh\:mm"));
            comboBoxTime.SelectedIndex = 0;
            comboBoxTime.Enabled = false; // Запрещаем изменение времени
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = TextBoxName.Text;
                string phone = phoneNumberBox.Text;
                int numberOfPeople = (int)NumericUpDownPeople.Value;

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }

                // Объединяем дату и время
                DateTime reservationDateTime = _selectedDate.Date + _selectedTime;

                // Добавляем бронирование в базу данных
                bool success = _database.AddReservation(name, phone, "example@email.com", reservationDateTime, _tableID, numberOfPeople);
                if (success)
                {
                    MessageBox.Show($"Бронирование на {numberOfPeople} человек(а) на {_selectedDate.ToShortDateString()} в {_selectedTime.ToString(@"hh\:mm")} успешно создано.");
                    ReservationCompleted?.Invoke();
                    Close();
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при создании бронирования.");
                }
            }
            catch (Exception ex)
            {
                // Логируем исключение для отладки
                MessageBox.Show($"Произошла ошибка: {ex.Message}\nДополнительная информация: {ex.StackTrace}");
            }
        }
    }
}