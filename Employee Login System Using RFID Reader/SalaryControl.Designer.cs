namespace Employee_Login_System_Using_RFID_Reader
{
    partial class SalaryControl
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
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.dgvPayout = new System.Windows.Forms.DataGridView();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.txtCurrentSalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeductions = new System.Windows.Forms.TextBox();
            this.txtRunningSalary = new System.Windows.Forms.TextBox();
            this.chkListDeductions = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPayout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxHoliday = new System.Windows.Forms.ListBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCashAdv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIncentive = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSSSLoan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPagibigLoan = new System.Windows.Forms.TextBox();
            this.lblOtherLoan = new System.Windows.Forms.Label();
            this.txtPagibig = new System.Windows.Forms.TextBox();
            this.txtSSS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhilhealth = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayout)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.Location = new System.Drawing.Point(12, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(119, 18);
            this.lblHeader1.TabIndex = 8;
            this.lblHeader1.Text = "Employee List";
            // 
            // dgvPayout
            // 
            this.dgvPayout.AllowUserToAddRows = false;
            this.dgvPayout.AllowUserToDeleteRows = false;
            this.dgvPayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lname,
            this.fname,
            this.mi,
            this.rfid,
            this.refdate,
            this.salary});
            this.dgvPayout.Location = new System.Drawing.Point(12, 30);
            this.dgvPayout.Name = "dgvPayout";
            this.dgvPayout.ReadOnly = true;
            this.dgvPayout.Size = new System.Drawing.Size(505, 150);
            this.dgvPayout.TabIndex = 9;
            this.dgvPayout.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayout_CellClick);
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
            // mi
            // 
            this.mi.HeaderText = "Middle Initial";
            this.mi.Name = "mi";
            this.mi.ReadOnly = true;
            // 
            // rfid
            // 
            this.rfid.HeaderText = "RFID";
            this.rfid.Name = "rfid";
            this.rfid.ReadOnly = true;
            // 
            // refdate
            // 
            this.refdate.HeaderText = "Reference Date";
            this.refdate.Name = "refdate";
            this.refdate.ReadOnly = true;
            this.refdate.Width = 150;
            // 
            // salary
            // 
            this.salary.HeaderText = "Running Salary";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Width = 150;
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader2.Location = new System.Drawing.Point(23, 184);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(123, 18);
            this.lblHeader2.TabIndex = 10;
            this.lblHeader2.Text = "Payout Details";
            // 
            // txtCurrentSalary
            // 
            this.txtCurrentSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentSalary.Location = new System.Drawing.Point(140, 569);
            this.txtCurrentSalary.Name = "txtCurrentSalary";
            this.txtCurrentSalary.ReadOnly = true;
            this.txtCurrentSalary.Size = new System.Drawing.Size(120, 22);
            this.txtCurrentSalary.TabIndex = 32;
            this.txtCurrentSalary.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Current Salary";
            // 
            // txtDeductions
            // 
            this.txtDeductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeductions.Location = new System.Drawing.Point(141, 524);
            this.txtDeductions.Name = "txtDeductions";
            this.txtDeductions.ReadOnly = true;
            this.txtDeductions.Size = new System.Drawing.Size(120, 22);
            this.txtDeductions.TabIndex = 31;
            this.txtDeductions.Text = "0";
            // 
            // txtRunningSalary
            // 
            this.txtRunningSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRunningSalary.Location = new System.Drawing.Point(140, 214);
            this.txtRunningSalary.Name = "txtRunningSalary";
            this.txtRunningSalary.ReadOnly = true;
            this.txtRunningSalary.Size = new System.Drawing.Size(120, 22);
            this.txtRunningSalary.TabIndex = 21;
            this.txtRunningSalary.Text = "0";
            // 
            // chkListDeductions
            // 
            this.chkListDeductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListDeductions.FormattingEnabled = true;
            this.chkListDeductions.Items.AddRange(new object[] {
            "PAGIBIG",
            "PHILHEALTH",
            "SSS",
            "LOAN",
            "CASH ADVANCE"});
            this.chkListDeductions.Location = new System.Drawing.Point(6, 21);
            this.chkListDeductions.Name = "chkListDeductions";
            this.chkListDeductions.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.chkListDeductions.Size = new System.Drawing.Size(120, 79);
            this.chkListDeductions.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Running Salary";
            // 
            // btnPayout
            // 
            this.btnPayout.Location = new System.Drawing.Point(140, 597);
            this.btnPayout.Name = "btnPayout";
            this.btnPayout.Size = new System.Drawing.Size(120, 23);
            this.btnPayout.TabIndex = 25;
            this.btnPayout.Text = "Payout";
            this.btnPayout.UseVisualStyleBackColor = true;
            this.btnPayout.Click += new System.EventHandler(this.btnPayout_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(442, 597);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(361, 597);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxHoliday);
            this.groupBox1.Controls.Add(this.btnModify);
            this.groupBox1.Location = new System.Drawing.Point(267, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 229);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Holiday Date Control";
            // 
            // lbxHoliday
            // 
            this.lbxHoliday.FormattingEnabled = true;
            this.lbxHoliday.Location = new System.Drawing.Point(6, 19);
            this.lbxHoliday.Name = "lbxHoliday";
            this.lbxHoliday.Size = new System.Drawing.Size(239, 173);
            this.lbxHoliday.TabIndex = 27;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(59, 199);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(120, 23);
            this.btnModify.TabIndex = 26;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "PAGIBIG Loan";
            // 
            // txtLoan
            // 
            this.txtLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoan.Location = new System.Drawing.Point(141, 440);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.ReadOnly = true;
            this.txtLoan.Size = new System.Drawing.Size(120, 22);
            this.txtLoan.TabIndex = 28;
            this.txtLoan.Text = "0";
            this.txtLoan.TextChanged += new System.EventHandler(this.TxtLoan_TextChanged);
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(141, 496);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(120, 22);
            this.txtTax.TabIndex = 30;
            this.txtTax.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tax";
            // 
            // txtCashAdv
            // 
            this.txtCashAdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashAdv.Location = new System.Drawing.Point(141, 468);
            this.txtCashAdv.Name = "txtCashAdv";
            this.txtCashAdv.ReadOnly = true;
            this.txtCashAdv.Size = new System.Drawing.Size(120, 22);
            this.txtCashAdv.TabIndex = 29;
            this.txtCashAdv.Text = "0";
            this.txtCashAdv.TextChanged += new System.EventHandler(this.txtCashAdv_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Cash Advance";
            // 
            // txtIncentive
            // 
            this.txtIncentive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncentive.Location = new System.Drawing.Point(140, 242);
            this.txtIncentive.Name = "txtIncentive";
            this.txtIncentive.Size = new System.Drawing.Size(120, 22);
            this.txtIncentive.TabIndex = 22;
            this.txtIncentive.Text = "0";
            this.txtIncentive.TextChanged += new System.EventHandler(this.txtIncentive_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Incentive";
            // 
            // txtSSSLoan
            // 
            this.txtSSSLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSSLoan.Location = new System.Drawing.Point(141, 412);
            this.txtSSSLoan.Name = "txtSSSLoan";
            this.txtSSSLoan.ReadOnly = true;
            this.txtSSSLoan.Size = new System.Drawing.Size(120, 22);
            this.txtSSSLoan.TabIndex = 27;
            this.txtSSSLoan.Text = "0";
            this.txtSSSLoan.TextChanged += new System.EventHandler(this.txtSSSLoan_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "SSS Loan";
            // 
            // txtPagibigLoan
            // 
            this.txtPagibigLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagibigLoan.Location = new System.Drawing.Point(141, 384);
            this.txtPagibigLoan.Name = "txtPagibigLoan";
            this.txtPagibigLoan.ReadOnly = true;
            this.txtPagibigLoan.Size = new System.Drawing.Size(120, 22);
            this.txtPagibigLoan.TabIndex = 26;
            this.txtPagibigLoan.Text = "0";
            this.txtPagibigLoan.TextChanged += new System.EventHandler(this.txtPagibigLoan_TextChanged);
            // 
            // lblOtherLoan
            // 
            this.lblOtherLoan.AutoSize = true;
            this.lblOtherLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherLoan.Location = new System.Drawing.Point(24, 443);
            this.lblOtherLoan.Name = "lblOtherLoan";
            this.lblOtherLoan.Size = new System.Drawing.Size(83, 16);
            this.lblOtherLoan.TabIndex = 41;
            this.lblOtherLoan.Text = "Other Loan";
            // 
            // txtPagibig
            // 
            this.txtPagibig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagibig.Location = new System.Drawing.Point(140, 300);
            this.txtPagibig.Name = "txtPagibig";
            this.txtPagibig.ReadOnly = true;
            this.txtPagibig.Size = new System.Drawing.Size(120, 22);
            this.txtPagibig.TabIndex = 23;
            this.txtPagibig.Text = "0";
            // 
            // txtSSS
            // 
            this.txtSSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSS.Location = new System.Drawing.Point(141, 356);
            this.txtSSS.Name = "txtSSS";
            this.txtSSS.ReadOnly = true;
            this.txtSSS.Size = new System.Drawing.Size(120, 22);
            this.txtSSS.TabIndex = 25;
            this.txtSSS.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 50;
            this.label10.Text = "SSS";
            // 
            // txtPhilhealth
            // 
            this.txtPhilhealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhilhealth.Location = new System.Drawing.Point(140, 328);
            this.txtPhilhealth.Name = "txtPhilhealth";
            this.txtPhilhealth.ReadOnly = true;
            this.txtPhilhealth.Size = new System.Drawing.Size(120, 22);
            this.txtPhilhealth.TabIndex = 24;
            this.txtPhilhealth.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "Philhealth";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 48;
            this.label12.Text = "PAGIBIG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkListDeductions);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(273, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 108);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deductions";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 527);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 16);
            this.label13.TabIndex = 55;
            this.label13.Text = "Total Deduc.";
            // 
            // SalaryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 632);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPagibig);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtPhilhealth);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSSS);
            this.Controls.Add(this.txtPagibigLoan);
            this.Controls.Add(this.lblOtherLoan);
            this.Controls.Add(this.txtSSSLoan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIncentive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCashAdv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPayout);
            this.Controls.Add(this.txtCurrentSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeductions);
            this.Controls.Add(this.txtRunningSalary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeader2);
            this.Controls.Add(this.dgvPayout);
            this.Controls.Add(this.lblHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SalaryControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalaryControl_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayout)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.DataGridView dgvPayout;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn mi;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfid;
        private System.Windows.Forms.DataGridViewTextBoxColumn refdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.TextBox txtCurrentSalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeductions;
        private System.Windows.Forms.TextBox txtRunningSalary;
        private System.Windows.Forms.CheckedListBox chkListDeductions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPayout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ListBox lbxHoliday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCashAdv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIncentive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSSSLoan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPagibigLoan;
        private System.Windows.Forms.Label lblOtherLoan;
        private System.Windows.Forms.TextBox txtPagibig;
        private System.Windows.Forms.TextBox txtSSS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhilhealth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
    }
}