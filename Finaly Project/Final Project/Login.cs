 


//using Final_Project.Migrations;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
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
        List<Employee> employeeList;
        private decimal hourlyPayroll;
        public frmLogin()
        {
            userDb = new CreateUserContext();
            InitializeComponent();
            userList = userDb.CreateUser.Select(c => c).Distinct().ToList();
            employeeList = new List<Employee>();
            employeeList.Add(new Employee { FirstName = "John", LastName = "Doe", Username = "jdoe", Password = "password", HourlyPay = 15.0m, Email = "jdoe@gmail.com" });

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
            CreateUser user = userList.FirstOrDefault(u => u.CreateUserId == username && u.Password == password);
            if (user != null && user.CreateUserId == username && user.Password == password)
            {
                MessageBox.Show("Login successful!");
                frmUserInterface frmUserInterface = new frmUserInterface(employeeList,username,password);
                frmUserInterface.Show();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Hide();
                frmUserInterface.AddEmployee(user.CreateUserId, user.Password);
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
            else if (CheckEmployeeLogin(username, password))
            {
                MessageBox.Show("Welcome, employee!");
                EmployeeUserInterface employeeUserInterface = new EmployeeUserInterface(hourlyPayroll);
                employeeUserInterface.Show();
                frmLogin frmLogin = new frmLogin();
                frmLogin.Hide();
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
        }
        private bool CheckEmployeeLogin(string username, string password)
        {
            return employeeList.Any(e => e.Username == username && e.Password == password);
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}