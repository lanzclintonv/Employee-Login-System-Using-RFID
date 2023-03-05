namespace Employee_Login_System_Using_RFID_Reader
{
    partial class GetAttendance
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
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvAttendanceRecord = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTime = new System.Windows.Forms.Label();
            this.realTime = new System.Windows.Forms.Timer(this.components);
            this.dtpNow = new System.Windows.Forms.DateTimePicker();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(393, 431);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvAttendanceRecord
            // 
            this.dgvAttendanceRecord.AllowUserToAddRows = false;
            this.dgvAttendanceRecord.AllowUserToDeleteRows = false;
            this.dgvAttendanceRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.lname,
            this.fname,
            this.mname,
            this.timein,
            this.timeout});
            this.dgvAttendanceRecord.Location = new System.Drawing.Point(15, 38);
            this.dgvAttendanceRecord.Name = "dgvAttendanceRecord";
            this.dgvAttendanceRecord.ReadOnly = true;
            this.dgvAttendanceRecord.Size = new System.Drawing.Size(453, 378);
            this.dgvAttendanceRecord.TabIndex = 2;
            // 
            // no
            // 
            this.no.HeaderText = "No.";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 50;
            // 
            // lname
            // 
            this.lname.HeaderText = "Last Name";
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            // 
            // fname
            // 
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            // 
            // mname
            // 
            this.mname.HeaderText = "Middle Initial";
            this.mname.Name = "mname";
            this.mname.ReadOnly = true;
            // 
            // timein
            // 
            this.timein.HeaderText = "Time In";
            this.timein.Name = "timein";
            this.timein.ReadOnly = true;
            // 
            // timeout
            // 
            this.timeout.HeaderText = "Time Out";
            this.timeout.Name = "timeout";
            this.timeout.ReadOnly = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(238, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 3;
            // 
            // realTime
            // 
            this.realTime.Interval = 60000;
            this.realTime.Tick += new System.EventHandler(this.realTime_Tick);
            // 
            // dtpNow
            // 
            this.dtpNow.CustomFormat = "MMMM dd, yyyy";
            this.dtpNow.Location = new System.Drawing.Point(15, 12);
            this.dtpNow.Name = "dtpNow";
            this.dtpNow.Size = new System.Drawing.Size(200, 20);
            this.dtpNow.TabIndex = 4;
            this.dtpNow.ValueChanged += new System.EventHandler(this.dtpNow_ValueChanged);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(368, 12);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "For Debugging Purposes";
            this.label1.Visible = false;
            // 
            // txtRFID
            // 
            this.txtRFID.Location = new System.Drawing.Point(138, 433);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(100, 20);
            this.txtRFID.TabIndex = 7;
            this.txtRFID.Visible = false;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(244, 431);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // GetAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 457);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtRFID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.dtpNow);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dgvAttendanceRecord);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "GetAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Attendance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetAttendance_FormClosing);
            this.Load += new System.EventHandler(this.GetAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvAttendanceRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn mname;
        private System.Windows.Forms.DataGridViewTextBoxColumn timein;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeout;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer realTime;
        private System.Windows.Forms.DateTimePicker dtpNow;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.Button btnTest;
    }
}