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
            this.tabAdmin.SuspendLayout();
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
            this.tabDeleteEmployee.Location = new System.Drawing.Point(4, 24);
            this.tabDeleteEmployee.Name = "tabDeleteEmployee";
            this.tabDeleteEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeleteEmployee.Size = new System.Drawing.Size(487, 232);
            this.tabDeleteEmployee.TabIndex = 1;
            this.tabDeleteEmployee.Text = "Delete Employee";
            this.tabDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // tabClockInOut
            // 
            this.tabClockInOut.Location = new System.Drawing.Point(4, 24);
            this.tabClockInOut.Name = "tabClockInOut";
            this.tabClockInOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabClockInOut.Size = new System.Drawing.Size(487, 232);
            this.tabClockInOut.TabIndex = 2;
            this.tabClockInOut.Text = "Clock In/Out";
            this.tabClockInOut.UseVisualStyleBackColor = true;
            // 
            // tabTimeWorked
            // 
            this.tabTimeWorked.Location = new System.Drawing.Point(4, 24);
            this.tabTimeWorked.Name = "tabTimeWorked";
            this.tabTimeWorked.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimeWorked.Size = new System.Drawing.Size(487, 232);
            this.tabTimeWorked.TabIndex = 3;
            this.tabTimeWorked.Text = "Time Worked";
            this.tabTimeWorked.UseVisualStyleBackColor = true;
            // 
            // tabPay
            // 
            this.tabPay.Location = new System.Drawing.Point(4, 24);
            this.tabPay.Name = "tabPay";
            this.tabPay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPay.Size = new System.Drawing.Size(487, 232);
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
    }
}