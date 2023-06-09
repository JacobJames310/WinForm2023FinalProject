﻿using System;
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
    public partial class EmployeeUserInterface : Form
    {
        private DateTime startTime;
        private TimeSpan totalElapsedTime;
        private DateTime lastResetTime;
        private decimal hourlyPayroll;

        public EmployeeUserInterface(decimal hourlyPayroll)
        {
            InitializeComponent();
            ResetStopWatch();
            this.hourlyPayroll = hourlyPayroll;

        }

        private decimal CalculatePay()
        {
            decimal pay = (decimal)totalElapsedTime.TotalHours * hourlyPayroll;
            return Math.Round(pay, 2);
        }
        private void btnClockIn_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer1.Enabled = true;
        }
        private void ResetStopWatch()
        {
            startTime = DateTime.Now;
            totalElapsedTime = TimeSpan.Zero;
            lastResetTime = DateTime.Now;
            UpdateStopWatchDisplay();
        }
        private void UpdateStopWatchDisplay()
        {
            TimeSpan elapsed;
            if (DateTime.Now.DayOfWeek != lastResetTime.DayOfWeek)
            {
                ResetStopWatch();
                return;
            }
            elapsed = totalElapsedTime + (DateTime.Now - startTime);
            rtbTimeWorked.Text = elapsed.ToString(@"hh\:mm\:ss");
            

        }
        private void Logout() 
        {
           

            this.Hide();


            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();


            this.Close();
        }
        private void btnCockOut_Click(object sender, EventArgs e)
        {
            totalElapsedTime += DateTime.Now - startTime;
            timer1.Enabled = false;
            UpdateStopWatchDisplay();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateStopWatchDisplay();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
        
    }
}
