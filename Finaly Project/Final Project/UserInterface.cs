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
    public partial class frmUserInterface : CreateUser
    {
        public frmUserInterface()
        {
            InitializeComponent();
            
        }
        
        public void Greeting()
        {
            lblGreeting.Text = $"Welcome {FirstName}";
        }
        private void tabAddEmploye_Click(object sender, EventArgs e)
        {

        }
        
    }
}
