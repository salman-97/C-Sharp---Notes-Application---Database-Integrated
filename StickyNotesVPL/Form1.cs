namespace StickyNotesVPL
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void signupBTN_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            this.Hide();
            signup.ShowDialog();
        }
    }
}