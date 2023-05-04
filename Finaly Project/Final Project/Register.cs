
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
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string companyName = txtCompanyName.Text;
            
            using (CreateUserContext CreateUserContext = new CreateUserContext())
            {
                CreateUserContext.CreateUser.Add(new CreateUser { CreateUserId = username, Password = password, Email = email, FirstName = firstName, LastName = lastName, CompanyName = companyName });
                CreateUserContext.SaveChanges();
            }
            MessageBox.Show("Registration successful!");
             
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();

        }
    }
}
