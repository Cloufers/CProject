namespace cafe
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void bookTableMenu_Click(object sender, EventArgs e)
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
        private void adminMenuButton_Click(object sender, EventArgs e)
        {
            using (PasswordForm passwordForm = new PasswordForm())
            {
                if (passwordForm.ShowDialog() == DialogResult.OK)
                {
                    string username = passwordForm.EnteredUsername; 
                    string enteredPassword = passwordForm.EnteredPassword;
                    string connectionString = "Host=ep-fragrant-shadow-a2mncv4x-pooler.eu-central-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_DXn7qEayl1Yz";

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