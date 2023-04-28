


using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        CreateUserContext userDb;
        List<CreateUser> userList;
        string username;
        string password;

        public Form1()
        {
            userDb = new CreateUserContext();
            InitializeComponent();


            userList = userDb.CreateUsers.Select(c => c).ToList();

            int foundUser = -1;
        }

        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            {
                Register f2 = new Register();
                f2.Show();
            }
                
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           Register register = new Register();
            register.Show();
            username = Convert.ToString(txtUsername.Text);
            password = Convert.ToString(txtPassword.Text);
        }
        
    }
}