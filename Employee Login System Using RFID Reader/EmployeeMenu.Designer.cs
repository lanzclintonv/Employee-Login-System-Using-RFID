namespace Employee_Login_System_Using_RFID_Reader
{
    partial class EmployeeMenu
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
            this.btnAttendanceRecord = new System.Windows.Forms.Button();
            this.btnViewSalary = new System.Windows.Forms.Button();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAttendanceRecord
            // 
            this.btnAttendanceRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendanceRecord.Location = new System.Drawing.Point(100, 100);
            this.btnAttendanceRecord.Name = "btnAttendanceRecord";
            this.btnAttendanceRecord.Size = new System.Drawing.Size(150, 40);
            this.btnAttendanceRecord.TabIndex = 1;
            this.btnAttendanceRecord.Text = "Attendance Record";
            this.btnAttendanceRecord.UseVisualStyleBackColor = true;
            this.btnAttendanceRecord.Click += new System.EventHandler(this.btnAttendanceRecord_Click);
            // 
            // btnViewSalary
            // 
            this.btnViewSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSalary.Location = new System.Drawing.Point(100, 146);
            this.btnViewSalary.Name = "btnViewSalary";
            this.btnViewSalary.Size = new System.Drawing.Size(150, 40);
            this.btnViewSalary.TabIndex = 2;
            this.btnViewSalary.Text = "View Salary";
            this.btnViewSalary.UseVisualStyleBackColor = true;
            this.btnViewSalary.Click += new System.EventHandler(this.btnViewSalary_Click);
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetings.Location = new System.Drawing.Point(12, 9);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(85, 18);
            this.lblGreetings.TabIndex = 8;
            this.lblGreetings.Text = "Welcome ";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(243, 272);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Logout";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // EmployeeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 307);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.btnViewSalary);
            this.Controls.Add(this.btnAttendanceRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EmployeeMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttendanceRecord;
        private System.Windows.Forms.Button btnViewSalary;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Button btnBack;
    }
}