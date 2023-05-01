 


using Final_Project.Migrations;
using Microsoft.Data.SqlClient;
using System.Data.Common;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_Project
{
    public partial class frmLogin : Form
    {
        CreateUserContext userDb;
        List<CreateUser> userList;
        

        public frmLogin()
        {
            userDb = new CreateUserContext();
            InitializeComponent();
            userList = userDb.CreateUser.Select(c => c).ToList();   
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
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool isValid = ValidateUser(username, password);

            if (isValid)
            {
                
                frmUserInterface frm = new frmUserInterface();
                frm.Show();
                this.Hide();
                lblCreate.Text = "";
            }
            else
            {
                lblCreate.Text = "Invalid username/password";
            }
        }
        private bool ValidateUser(string username, string password)
        {
            
            using (var db = new CreateUserContext())
            {
                return db.CreateUser.Any(u => u.CreateUserId == username && u.Password == password);
            }
        }
    }
}