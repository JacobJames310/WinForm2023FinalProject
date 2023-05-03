using Azure;
using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_Project
{
    public partial class frmUserInterface : Form
    {
        private List<Employee> employeeList ;
        public frmUserInterface(List<Employee> employeeList)
        {
            
            InitializeComponent();
            this.employeeList = employeeList;

        }
        
        
        
        private void tabAddEmploye_Click(object sender, EventArgs e)
        {
            

        }
        
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabDeleteEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddEmployee_Click_1(object sender, EventArgs e)
        {
            
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            decimal hourlyPay = Convert.ToDecimal(txtHourlyPay.Text);
            
            Employee newEmployee = new Employee()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password,
                Username = username,
                HourlyPay = hourlyPay,
            };
            
            employeeList.Add(newEmployee);
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtHourlyPay.Text = "";
            rtbEmployeeInfo.Text += $"{firstName} {lastName}'s email is {email} and their username is {username} and password is {password}, their hourly pay is {hourlyPay}.\n";
            rtbPayOverview.Text += $"{firstName} {lastName} makes {hourlyPay:c} per hour.\n";
            foreach (Employee cbEmployee in employeeList)
            {
                cbEmployees.Items.Add(username);
                
            }
            
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            string deleteUsername = txtDeleteUser.Text;
            string deletePassword = txtDeletePassword.Text;

            Employee employeeToRemove = null;

            foreach (Employee emp in employeeList)
            {
                if (emp.Username == deleteUsername && emp.Password == deletePassword)
                {
                    employeeToRemove = emp;
                    break;
                }
            }
            if (employeeToRemove != null)
            {
                employeeList.Remove(employeeToRemove);
                rtbEmployeeInfo.Text = "";

                foreach (Employee emp in employeeList)
                {
                    rtbEmployeeInfo.AppendText(emp.Username + "\n");
                }

                MessageBox.Show("Employee removed successfully.");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
            txtDeletePassword.Text = "";
            txtDeleteUser.Text = "";
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
        private void Logout()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";

            
            this.Hide();

            
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();

            
            this.Close();
        }

        private void txtHourlyPay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnUpdatePay_Click(object sender, EventArgs e)
        {
            
            
        }
        public void AddEmployee(string username, string password)
        {
            employeeList.Add(new Employee { Username = username, Password = password });
        }
        private void btnUpdatePay_Click_1(object sender, EventArgs e)
        {
            if(cbEmployees.SelectedIndex == -1) return;

            var selectedEmployee = employeeList[cbEmployees.SelectedIndex];

            var newHourlyPay = decimal.Parse(txtUpdatePay.Text);
            selectedEmployee.HourlyPay = newHourlyPay;

            txtUpdatePay.Clear();
            rtbPayOverview.Text = selectedEmployee.HourlyPay.ToString("C");
        }

        private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmployees.SelectedIndex == -1) return;
            
            var selectedEmployees = employeeList
                [cbEmployees.SelectedIndex];
            rtbPayOverview.Text = selectedEmployees.HourlyPay.ToString("C");
            
            
        }
    }
}
