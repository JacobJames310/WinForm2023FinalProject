namespace Final_Project
{
    partial class EmployeeUserInterface
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
            this.components = new System.ComponentModel.Container();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.tabEmployees = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtbTimeWorked = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnClockIn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCockOut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabEmployees.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(636, 68);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(0, 15);
            this.lblGreeting.TabIndex = 3;
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.tabPage1);
            this.tabEmployees.Controls.Add(this.tabPage2);
            this.tabEmployees.Controls.Add(this.tabPage3);
            this.tabEmployees.Controls.Add(this.tabPage4);
            this.tabEmployees.Location = new System.Drawing.Point(140, 114);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.SelectedIndex = 0;
            this.tabEmployees.Size = new System.Drawing.Size(552, 280);
            this.tabEmployees.TabIndex = 4;
            this.tabEmployees.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtbTimeWorked);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Time Worked";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtbTimeWorked
            // 
            this.rtbTimeWorked.Location = new System.Drawing.Point(6, 6);
            this.rtbTimeWorked.Name = "rtbTimeWorked";
            this.rtbTimeWorked.Size = new System.Drawing.Size(284, 240);
            this.rtbTimeWorked.TabIndex = 0;
            this.rtbTimeWorked.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PayOverview";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(532, 240);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnClockIn);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(544, 252);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Clock In";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnClockIn
            // 
            this.btnClockIn.Location = new System.Drawing.Point(333, 52);
            this.btnClockIn.Name = "btnClockIn";
            this.btnClockIn.Size = new System.Drawing.Size(181, 133);
            this.btnClockIn.TabIndex = 0;
            this.btnClockIn.Text = "Clock In";
            this.btnClockIn.UseVisualStyleBackColor = true;
            this.btnClockIn.Click += new System.EventHandler(this.btnClockIn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnCockOut);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(544, 252);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Clock out";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCockOut
            // 
            this.btnCockOut.Location = new System.Drawing.Point(336, 51);
            this.btnCockOut.Name = "btnCockOut";
            this.btnCockOut.Size = new System.Drawing.Size(181, 134);
            this.btnCockOut.TabIndex = 0;
            this.btnCockOut.Text = "Clock Out";
            this.btnCockOut.UseVisualStyleBackColor = true;
            this.btnCockOut.Click += new System.EventHandler(this.btnCockOut_Click);
            // 
            // EmployeeUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabEmployees);
            this.Controls.Add(this.lblGreeting);
            this.Name = "EmployeeUserInterface";
            this.Text = "EmployeeUserInterface";
            this.tabEmployees.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGreeting;
        private TabControl tabEmployees;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox rtbTimeWorked;
        private RichTextBox richTextBox1;
        private TabPage tabPage3;
        private Button btnClockIn;
        private TabPage tabPage4;
        private Button btnCockOut;
        private System.Windows.Forms.Timer timer1;
    }
}