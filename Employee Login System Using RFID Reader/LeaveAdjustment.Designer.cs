namespace Employee_Login_System_Using_RFID_Reader
{
    partial class LeaveAdjustment
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
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBasePay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnVacation = new System.Windows.Forms.RadioButton();
            this.rbtnSick = new System.Windows.Forms.RadioButton();
            this.btnSickLeave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToAddRows = false;
            this.dgvRecord.AllowUserToDeleteRows = false;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.lname,
            this.fname,
            this.mname,
            this.date,
            this.rfid,
            this.timein,
            this.timeout,
            this.salary});
            this.dgvRecord.Location = new System.Drawing.Point(13, 39);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.ReadOnly = true;
            this.dgvRecord.Size = new System.Drawing.Size(459, 381);
            this.dgvRecord.TabIndex = 7;
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
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // rfid
            // 
            this.rfid.HeaderText = "RFID";
            this.rfid.Name = "rfid";
            this.rfid.ReadOnly = true;
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
            // salary
            // 
            this.salary.HeaderText = "Salary Earned";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(397, 631);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MMMM dd, yyyy";
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(67, 9);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Location = new System.Drawing.Point(13, 12);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(48, 17);
            this.chkFilter.TabIndex = 8;
            this.chkFilter.Text = "Filter";
            this.chkFilter.UseVisualStyleBackColor = true;
            this.chkFilter.CheckedChanged += new System.EventHandler(this.chkFilter_CheckedChanged_1);
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader2.Location = new System.Drawing.Point(10, 423);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(119, 18);
            this.lblHeader2.TabIndex = 11;
            this.lblHeader2.Text = "Set Leave For";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "RFID";
            // 
            // txtRFID
            // 
            this.txtRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFID.Location = new System.Drawing.Point(147, 463);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(156, 22);
            this.txtRFID.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(147, 491);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 22);
            this.txtName.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // txtBasePay
            // 
            this.txtBasePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasePay.Location = new System.Drawing.Point(147, 519);
            this.txtBasePay.Name = "txtBasePay";
            this.txtBasePay.Size = new System.Drawing.Size(156, 22);
            this.txtBasePay.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Base Pay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Leave Type";
            // 
            // rbtnVacation
            // 
            this.rbtnVacation.AutoSize = true;
            this.rbtnVacation.Checked = true;
            this.rbtnVacation.Location = new System.Drawing.Point(147, 550);
            this.rbtnVacation.Name = "rbtnVacation";
            this.rbtnVacation.Size = new System.Drawing.Size(100, 17);
            this.rbtnVacation.TabIndex = 28;
            this.rbtnVacation.TabStop = true;
            this.rbtnVacation.Text = "Vacation Leave";
            this.rbtnVacation.UseVisualStyleBackColor = true;
            // 
            // rbtnSick
            // 
            this.rbtnSick.AutoSize = true;
            this.rbtnSick.Location = new System.Drawing.Point(147, 573);
            this.rbtnSick.Name = "rbtnSick";
            this.rbtnSick.Size = new System.Drawing.Size(79, 17);
            this.rbtnSick.TabIndex = 29;
            this.rbtnSick.TabStop = true;
            this.rbtnSick.Text = "Sick Leave";
            this.rbtnSick.UseVisualStyleBackColor = true;
            // 
            // btnSickLeave
            // 
            this.btnSickLeave.Location = new System.Drawing.Point(147, 596);
            this.btnSickLeave.Name = "btnSickLeave";
            this.btnSickLeave.Size = new System.Drawing.Size(75, 23);
            this.btnSickLeave.TabIndex = 30;
            this.btnSickLeave.Text = "Set Leave";
            this.btnSickLeave.UseVisualStyleBackColor = true;
            this.btnSickLeave.Click += new System.EventHandler(this.btnSickLeave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(228, 596);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // LeaveAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 657);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSickLeave);
            this.Controls.Add(this.rbtnSick);
            this.Controls.Add(this.rbtnVacation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBasePay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRFID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeader2);
            this.Controls.Add(this.dgvRecord);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.chkFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LeaveAdjustment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave Adjustment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LeaveAdjustment_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn mname;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfid;
        private System.Windows.Forms.DataGridViewTextBoxColumn timein;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeout;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBasePay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnVacation;
        private System.Windows.Forms.RadioButton rbtnSick;
        private System.Windows.Forms.Button btnSickLeave;
        private System.Windows.Forms.Button btnClear;
    }
}