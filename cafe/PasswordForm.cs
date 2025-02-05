namespace cafe
{
    public partial class PasswordForm : Form
    {
        public string EnteredPassword { get; private set; }
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            EnteredPassword = passwordTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cyberButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
