namespace cafe
{
    public partial class PasswordForm : Form
    {
        public string EnteredPassword { get; private set; }
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            EnteredPassword = passwordTextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
