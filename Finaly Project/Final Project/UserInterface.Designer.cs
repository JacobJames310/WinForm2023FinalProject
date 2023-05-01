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
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabAddEmploye = new System.Windows.Forms.TabPage();
            this.tabDeleteEmployee = new System.Windows.Forms.TabPage();
            this.tabClockInOut = new System.Windows.Forms.TabPage();
            this.tabTimeWorked = new System.Windows.Forms.TabPage();
            this.tabPay = new System.Windows.Forms.TabPage();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtDeleteFirstName = new System.Windows.Forms.TextBox();
            this.txtDeleteUser = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabAdmin.SuspendLayout();
            this.tabAddEmploye.SuspendLayout();
            this.tabDeleteEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabAddEmploye);
            this.tabAdmin.Controls.Add(this.tabDeleteEmployee);
            this.tabAdmin.Controls.Add(this.tabClockInOut);
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
            this.tabAddEmploye.Controls.Add(this.txtLastName);
            this.tabAddEmploye.Controls.Add(this.txtFirstName);
            this.tabAddEmploye.Controls.Add(this.txtEmail);
            this.tabAddEmploye.Controls.Add(this.txtPassword);
            this.tabAddEmploye.Controls.Add(this.txtUsername);
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
            // tabDeleteEmployee
            // 
            this.tabDeleteEmployee.Controls.Add(this.txtDeleteFirstName);
            this.tabDeleteEmployee.Controls.Add(this.label10);
            this.tabDeleteEmployee.Controls.Add(this.label9);
            this.tabDeleteEmployee.Controls.Add(this.txtDeleteUser);
            this.tabDeleteEmployee.Location = new System.Drawing.Point(4, 24);
            this.tabDeleteEmployee.Name = "tabDeleteEmployee";
            this.tabDeleteEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeleteEmployee.Size = new System.Drawing.Size(540, 241);
            this.tabDeleteEmployee.TabIndex = 1;
            this.tabDeleteEmployee.Text = "Delete Employee";
            this.tabDeleteEmployee.UseVisualStyleBackColor = true;
            this.tabDeleteEmployee.Click += new System.EventHandler(this.tabDeleteEmployee_Click);
            // 
            // tabClockInOut
            // 
            this.tabClockInOut.Location = new System.Drawing.Point(4, 24);
            this.tabClockInOut.Name = "tabClockInOut";
            this.tabClockInOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabClockInOut.Size = new System.Drawing.Size(540, 241);
            this.tabClockInOut.TabIndex = 2;
            this.tabClockInOut.Text = "Clock In/Out";
            this.tabClockInOut.UseVisualStyleBackColor = true;
            // 
            // tabTimeWorked
            // 
            this.tabTimeWorked.Location = new System.Drawing.Point(4, 24);
            this.tabTimeWorked.Name = "tabTimeWorked";
            this.tabTimeWorked.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimeWorked.Size = new System.Drawing.Size(540, 241);
            this.tabTimeWorked.TabIndex = 3;
            this.tabTimeWorked.Text = "Time Worked";
            this.tabTimeWorked.UseVisualStyleBackColor = true;
            // 
            // tabPay
            // 
            this.tabPay.Location = new System.Drawing.Point(4, 24);
            this.tabPay.Name = "tabPay";
            this.tabPay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPay.Size = new System.Drawing.Size(540, 241);
            this.tabPay.TabIndex = 4;
            this.tabPay.Text = "Pay Overview";
            this.tabPay.UseVisualStyleBackColor = true;
            // 
            // tabEmployees
            // 
            this.tabEmployees.Location = new System.Drawing.Point(4, 24);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(540, 241);
            this.tabEmployees.TabIndex = 5;
            this.tabEmployees.Text = "Employees";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(603, 44);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(0, 15);
            this.lblGreeting.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(120, 42);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(138, 23);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(138, 23);
            this.txtPassword.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(138, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 116);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(138, 23);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(120, 141);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(138, 23);
            this.txtLastName.TabIndex = 6;
            // 
            // txtDeleteFirstName
            // 
            this.txtDeleteFirstName.Location = new System.Drawing.Point(122, 73);
            this.txtDeleteFirstName.Name = "txtDeleteFirstName";
            this.txtDeleteFirstName.Size = new System.Drawing.Size(138, 23);
            this.txtDeleteFirstName.TabIndex = 20;
            this.txtDeleteFirstName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtDeleteUser
            // 
            this.txtDeleteUser.Location = new System.Drawing.Point(122, 48);
            this.txtDeleteUser.Name = "txtDeleteUser";
            this.txtDeleteUser.Size = new System.Drawing.Size(138, 23);
            this.txtDeleteUser.TabIndex = 19;
            this.txtDeleteUser.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "First Name:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Username:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // frmUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.tabAdmin);
            this.Name = "frmUserInterface";
            this.Text = "UserInterface";
            this.tabAdmin.ResumeLayout(false);
            this.tabAddEmploye.ResumeLayout(false);
            this.tabAddEmploye.PerformLayout();
            this.tabDeleteEmployee.ResumeLayout(false);
            this.tabDeleteEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabAdmin;
        private TabPage tabAddEmploye;
        private TabPage tabDeleteEmployee;
        private TabPage tabClockInOut;
        private TabPage tabTimeWorked;
        private TabPage tabPay;
        private TabPage tabEmployees;
        private Label lblGreeting;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDeleteFirstName;
        private TextBox txtDeleteUser;
        private Label label9;
        private Label label10;
    }
}