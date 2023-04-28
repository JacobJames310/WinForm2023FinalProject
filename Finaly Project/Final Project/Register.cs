using Final_Project.Migrations;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmRegister : Form
    {
        CreateUserContext userDb;
        List<CreateUser> userList;
        public frmRegister()
        {
            userDb = new CreateUserContext();
            InitializeComponent();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister f2 = new frmRegister();
            frmLogin f1 = new frmLogin();



            if (txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "")
            {
                lblError.Visible = true;
                f2.Close();
            }
            else
            {
                lblError.Visible = false;
                f1.Show();
                f2.Close();
            }
            
        }
    }
}
