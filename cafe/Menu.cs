namespace cafe
{
    public partial class Menu : Form
    {
        private readonly string _connectionString;

        public Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PickTableWindow form3Tables = new PickTableWindow();
            form3Tables.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReserveTableWindow form2 = new ReserveTableWindow();
            form2.Show();
            Hide();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            using (PasswordForm passwordForm = new PasswordForm())
            {
                if (passwordForm.ShowDialog() == DialogResult.OK)
                {
                    string username = "admin"; // Предполагаем, что имя пользователя всегда "admin"
                    string enteredPassword = passwordForm.EnteredPassword;
                    string connectionString = "Host=localhost;User ID=postgres;Password=1234;Database=Business";

                    Database db = new Database(connectionString);
                    if (db.AuthenticateUser(username, enteredPassword))
                    {
                        AdminPanel adminPanel = new AdminPanel();
                        adminPanel.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}