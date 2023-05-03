namespace Final_Project
{
    partial class frmUserInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblGreeting = new System.Windows.Forms.Label();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.rtbEmployeeInfo = new System.Windows.Forms.RichTextBox();
            this.tabPay = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.rtbPayOverview = new System.Windows.Forms.RichTextBox();
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.btnUpdatePay = new System.Windows.Forms.Button();
            this.txtUpdatePay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabTimeWorked = new System.Windows.Forms.TabPage();
            this.rtbTimeWorked = new System.Windows.Forms.RichTextBox();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabAddEmploye = new System.Windows.Forms.TabPage();
            this.txtHourlyPay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDeleteEmployee = new System.Windows.Forms.TabPage();
            this.txtDeletePassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeleteUser = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabEmployees.SuspendLayout();
            this.tabPay.SuspendLayout();
            this.tabTimeWorked.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tabAddEmploye.SuspendLayout();
            this.tabDeleteEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(603, 44);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(0, 15);
            this.lblGreeting.TabIndex = 1;
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.rtbEmployeeInfo);
            this.tabEmployees.Location = new System.Drawing.Point(4, 24);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(540, 241);
            this.tabEmployees.TabIndex = 5;
            this.tabEmployees.Text = "Employees";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // rtbEmployeeInfo
            // 
            this.rtbEmployeeInfo.Location = new System.Drawing.Point(6, 6);
            this.rtbEmployeeInfo.Name = "rtbEmployeeInfo";
            this.rtbEmployeeInfo.Size = new System.Drawing.Size(528, 229);
            this.rtbEmployeeInfo.TabIndex = 12;
            this.rtbEmployeeInfo.Text = "";
            // 
            // tabPay
            // 
            this.tabPay.Controls.Add(this.label11);
            this.tabPay.Controls.Add(this.rtbPayOverview);
            this.tabPay.Controls.Add(this.cbEmployees);
            this.tabPay.Controls.Add(this.btnUpdatePay);
            this.tabPay.Controls.Add(this.txtUpdatePay);
            this.tabPay.Controls.Add(this.label8);
            this.tabPay.Location = new System.Drawing.Point(4, 24);
            this.tabPay.Name = "tabPay";
            this.tabPay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPay.Size = new System.Drawing.Size(540, 241);
            this.tabPay.TabIndex = 4;
            this.tabPay.Text = "Pay Overview";
            this.tabPay.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(304, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "What do you want to update their pay too?";
            // 
            // rtbPayOverview
            // 
            this.rtbPayOverview.Location = new System.Drawing.Point(6, 6);
            this.rtbPayOverview.Name = "rtbPayOverview";
            this.rtbPayOverview.Size = new System.Drawing.Size(300, 229);
            this.rtbPayOverview.TabIndex = 12;
            this.rtbPayOverview.Text = "";
            // 
            // cbEmployees
            // 
            this.cbEmployees.FormattingEnabled = true;
            this.cbEmployees.Location = new System.Drawing.Point(361, 66);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Size = new System.Drawing.Size(121, 23);
            this.cbEmployees.TabIndex = 11;
            this.cbEmployees.SelectedIndexChanged += new System.EventHandler(this.cbEmployees_SelectedIndexChanged);
            // 
            // btnUpdatePay
            // 
            this.btnUpdatePay.Location = new System.Drawing.Point(372, 197);
            this.btnUpdatePay.Name = "btnUpdatePay";
            this.btnUpdatePay.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePay.TabIndex = 10;
            this.btnUpdatePay.Text = "Update Pay";
            this.btnUpdatePay.UseVisualStyleBackColor = true;
            this.btnUpdatePay.Click += new System.EventHandler(this.btnUpdatePay_Click_1);
            // 
            // txtUpdatePay
            // 
            this.txtUpdatePay.Location = new System.Drawing.Point(329, 147);
            this.txtUpdatePay.Name = "txtUpdatePay";
            this.txtUpdatePay.Size = new System.Drawing.Size(186, 23);
            this.txtUpdatePay.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(312, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 36);
            this.label8.TabIndex = 8;
            this.label8.Text = "What employee\'s hourly pay are you updating?";
            // 
            // tabTimeWorked
            // 
            this.tabTimeWorked.Controls.Add(this.rtbTimeWorked);
            this.tabTimeWorked.Location = new System.Drawing.Point(4, 24);
            this.tabTimeWorked.Name = "tabTimeWorked";
            this.tabTimeWorked.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimeWorked.Size = new System.Drawing.Size(540, 241);
            this.tabTimeWorked.TabIndex = 3;
            this.tabTimeWorked.Text = "Time Worked";
            this.tabTimeWorked.UseVisualStyleBackColor = true;
            // 
            // rtbTimeWorked
            // 
            this.rtbTimeWorked.Location = new System.Drawing.Point(6, 6);
            this.rtbTimeWorked.Name = "rtbTimeWorked";
            this.rtbTimeWorked.Size = new System.Drawing.Size(528, 229);
            this.rtbTimeWorked.TabIndex = 0;
            this.rtbTimeWorked.Text = "";
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabAddEmploye);
            this.tabAdmin.Controls.Add(this.tabDeleteEmployee);
            this.tabAdmin.Controls.Add(this.tabTimeWorked);
            this.tabAdmin.Controls.Add(this.tabPay);
            this.tabAdmin.Controls.Add(this.tabEmployees);
            this.tabAdmin.Location = new System.Drawing.Point(93, 90);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(548, 269);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.Tag = "";
            // 
            // tabAddEmploye
            // 
            this.tabAddEmploye.Controls.Add(this.txtHourlyPay);
            this.tabAddEmploye.Controls.Add(this.label12);
            this.tabAddEmploye.Controls.Add(this.btnAddEmployee);
            this.tabAddEmploye.Controls.Add(this.txtEmail);
            this.tabAddEmploye.Controls.Add(this.txtPassword);
            this.tabAddEmploye.Controls.Add(this.txtUsername);
            this.tabAddEmploye.Controls.Add(this.txtLastName);
            this.tabAddEmploye.Controls.Add(this.txtFirstName);
            this.tabAddEmploye.Controls.Add(this.label5);
            this.tabAddEmploye.Controls.Add(this.label4);
            this.tabAddEmploye.Controls.Add(this.label3);
            this.tabAddEmploye.Controls.Add(this.label2);
            this.tabAddEmploye.Controls.Add(this.label1);
            this.tabAddEmploye.Location = new System.Drawing.Point(4, 24);
            this.tabAddEmploye.Name = "tabAddEmploye";
            this.tabAddEmploye.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddEmploye.Size = new System.Drawing.Size(540, 241);
            this.tabAddEmploye.TabIndex = 0;
            this.tabAddEmploye.Text = "Add Employee";
            this.tabAddEmploye.UseVisualStyleBackColor = true;
            this.tabAddEmploye.Click += new System.EventHandler(this.tabAddEmploye_Click);
            // 
            // txtHourlyPay
            // 
            this.txtHourlyPay.Location = new System.Drawing.Point(108, 215);
            this.txtHourlyPay.Name = "txtHourlyPay";
            this.txtHourlyPay.Size = new System.Drawing.Size(100, 23);
            this.txtHourlyPay.TabIndex = 12;
            this.txtHourlyPay.TextChanged += new System.EventHandler(this.txtHourlyPay_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Hourly Pay:";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(281, 106);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(105, 23);
            this.btnAddEmployee.TabIndex = 10;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(108, 136);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 8;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(108, 95);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 23);
            this.txtUsername.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(108, 51);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 23);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(108, 11);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 23);
            this.txtFirstName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // tabDeleteEmployee
            // 
            this.tabDeleteEmployee.Controls.Add(this.txtDeletePassword);
            this.tabDeleteEmployee.Controls.Add(this.label7);
            this.tabDeleteEmployee.Controls.Add(this.btnDeleteEmployee);
            this.tabDeleteEmployee.Controls.Add(this.label6);
            this.tabDeleteEmployee.Controls.Add(this.txtDeleteUser);
            this.tabDeleteEmployee.Controls.Add(this.label10);
            this.tabDeleteEmployee.Controls.Add(this.label9);
            this.tabDeleteEmployee.Location = new System.Drawing.Point(4, 24);
            this.tabDeleteEmployee.Name = "tabDeleteEmployee";
            this.tabDeleteEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeleteEmployee.Size = new System.Drawing.Size(540, 241);
            this.tabDeleteEmployee.TabIndex = 1;
            this.tabDeleteEmployee.Text = "Delete Employee";
            this.tabDeleteEmployee.UseVisualStyleBackColor = true;
            this.tabDeleteEmployee.Click += new System.EventHandler(this.tabDeleteEmployee_Click);
            // 
            // txtDeletePassword
            // 
            this.txtDeletePassword.Location = new System.Drawing.Point(122, 87);
            this.txtDeletePassword.Name = "txtDeletePassword";
            this.txtDeletePassword.Size = new System.Drawing.Size(138, 23);
            this.txtDeletePassword.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Password:";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(282, 68);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteEmployee.TabIndex = 23;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Username:";
            // 
            // txtDeleteUser
            // 
            this.txtDeleteUser.Location = new System.Drawing.Point(122, 48);
            this.txtDeleteUser.Name = "txtDeleteUser";
            this.txtDeleteUser.Size = new System.Drawing.Size(138, 23);
            this.txtDeleteUser.TabIndex = 19;
            this.txtDeleteUser.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 15);
            this.label10.TabIndex = 17;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 18;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(675, 27);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.tabAdmin);
            this.Name = "frmUserInterface";
            this.Text = "UserInterface";
            this.tabEmployees.ResumeLayout(false);
            this.tabPay.ResumeLayout(false);
            this.tabPay.PerformLayout();
            this.tabTimeWorked.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            this.tabAddEmploye.ResumeLayout(false);
            this.tabAddEmploye.PerformLayout();
            this.tabDeleteEmployee.ResumeLayout(false);
            this.tabDeleteEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblGreeting;
        private TabPage tabEmployees;
        private TabPage tabPay;
        private TabPage tabTimeWorked;
        private TabPage tabClockInOut;
        private TabControl tabAdmin;
        private TabPage tabAddEmploye;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabDeleteEmployee;
        private TextBox txtDeleteUser;
        private Label label10;
        private Label label9;
        private Label label6;
        private Button btnAddEmployee;
        private RichTextBox rtbEmployeeInfo;
        private Button btnDeleteEmployee;
        private TextBox txtDeletePassword;
        private Label label7;
        private Button btnLogout;
        private RichTextBox rtbTimeWorked;
        private TextBox txtHourlyPay;
        private Label label12;
        private Button btnUpdatePay;
        private TextBox txtUpdatePay;
        private Label label8;
        private ComboBox cbEmployees;
        private RichTextBox rtbPayOverview;
        private Label label11;
    }
}