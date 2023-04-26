namespace Final_Project
{
    public partial class Form1 : Form
    {
        Employee timeSheet = new Employee();
        List<CreateUser> timeSheetUsers = new List<CreateUser>();
        Employee creditKarma= new Employee();
        List<CreateUser> creditKarmaUsers = new List<CreateUser>();

        public Form1()
        {
            InitializeComponent();
            timeSheetUsers.Add(new CreateUser("jacobjames101", "123yes", "jacob993@yahoo.com", "Jacob", "James", "556-112"));
            timeSheetUsers.Add(new CreateUser("stan199", "401dfls", "stan001@gmail.com", "Stan", "Marsh", "991-449"));
            timeSheetUsers.Add(new CreateUser("kenny994", "fdskl949", "mccormick90@hotmail.com", "Kenny", "McCormick", "049-491"));
            timeSheetUsers.Add(new CreateUser("erik191", "ktj113", "erik019@aol.com", "Eric", "Cartman", "331-305"));

        }

        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register f2 = new Register();
            f2.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUsername.Text.Equals(username)) && (txtPassword.Text.Equals(password)))
            {

            }
        }
    }
}