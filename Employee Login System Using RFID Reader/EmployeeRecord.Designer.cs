namespace Employee_Login_System_Using_RFID_Reader
{
    partial class EmployeeRecord
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary_earned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MMMM dd, yyyy";
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(67, 10);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToAddRows = false;
            this.dgvRecord.AllowUserToDeleteRows = false;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.time_in,
            this.time_out,
            this.salary_earned});
            this.dgvRecord.Location = new System.Drawing.Point(13, 39);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.ReadOnly = true;
            this.dgvRecord.Size = new System.Drawing.Size(442, 377);
            this.dgvRecord.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(380, 422);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time_in
            // 
            this.time_in.HeaderText = "Time In";
            this.time_in.Name = "time_in";
            this.time_in.ReadOnly = true;
            // 
            // time_out
            // 
            this.time_out.HeaderText = "Time Out";
            this.time_out.Name = "time_out";
            this.time_out.ReadOnly = true;
            // 
            // salary_earned
            // 
            this.salary_earned.HeaderText = "Salary Earned";
            this.salary_earned.Name = "salary_earned";
            this.salary_earned.ReadOnly = true;
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Location = new System.Drawing.Point(13, 13);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(48, 17);
            this.chkFilter.TabIndex = 3;
            this.chkFilter.Text = "Filter";
            this.chkFilter.UseVisualStyleBackColor = true;
            this.chkFilter.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged);
            // 
            // EmployeeRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 457);
            this.Controls.Add(this.chkFilter);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvRecord);
            this.Controls.Add(this.dtpDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EmployeeRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeRecord_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary_earned;
        private System.Windows.Forms.CheckBox chkFilter;
    }
}