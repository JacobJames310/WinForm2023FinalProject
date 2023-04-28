


using Final_Project.Migrations;
using System.Data.Common;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_Project
{
    public partial class frmLogin : Form
    {
        CreateUserContext userDb;
        List<CreateUser> userList;
        string username;
        string password;

        public frmLogin()
        {
            userDb = new CreateUserContext();
            InitializeComponent();

        }

        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
                
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            userList = userDb.CreateUsers.OrderBy(c => c).Where(c => c.CreateUserId == username).Select(c => c).ToList();
            userList = userDb.CreateUsers.OrderBy(c => c).Where(c => c.Password == password).Select(c => c).ToList();
            frmUserInterface frmUserInterface = new frmUserInterface();
            frmUserInterface.Show();

            for (int i = 0; i < userList.Count; i++)
            {
                
            }

            
        }
        
    }
}