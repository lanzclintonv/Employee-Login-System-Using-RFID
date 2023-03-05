namespace Employee_Login_System_Using_RFID_Reader
{
    partial class EmployeeSalary
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
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary_earned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkListDeductions = new System.Windows.Forms.CheckedListBox();
            this.txtRunningSalary = new System.Windows.Forms.TextBox();
            this.txtDeductions = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentSalary = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.Location = new System.Drawing.Point(12, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(125, 18);
            this.lblHeader1.TabIndex = 9;
            this.lblHeader1.Text = "Payout History";
            // 
            // dgvPayout
            // 
            this.dgvPayout.AllowUserToAddRows = false;
            this.dgvPayout.AllowUserToDeleteRows = false;
            this.dgvPayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.from,
            this.to,
            this.salary_earned,
            this.deductions,
            this.payout});
            this.dgvPayout.Location = new System.Drawing.Point(13, 31);
            this.dgvPayout.Name = "dgvPayout";
            this.dgvPayout.ReadOnly = true;
            this.dgvPayout.Size = new System.Drawing.Size(455, 250);
            this.dgvPayout.TabIndex = 10;
            // 
            // from
            // 
            this.from.HeaderText = "From";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            // 
            // to
            // 
            this.to.HeaderText = "To";
            this.to.Name = "to";
            this.to.ReadOnly = true;
            // 
            // salary_earned
            // 
            this.salary_earned.HeaderText = "Salary Earned";
            this.salary_earned.Name = "salary_earned";
            this.salary_earned.ReadOnly = true;
            // 
            // deductions
            // 
            this.deductions.HeaderText = "Deductions";
            this.deductions.Name = "deductions";
            this.deductions.ReadOnly = true;
            // 
            // payout
            // 
            this.payout.HeaderText = "Payout";
            this.payout.Name = "payout";
            this.payout.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Running Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Deductions";
            // 
            // chkListDeductions
            // 
            this.chkListDeductions.FormattingEnabled = true;
            this.chkListDeductions.Items.AddRange(new object[] {
            "PAGIBIG",
            "PHILHEALTH",
            "SSS"});
            this.chkListDeductions.Location = new System.Drawing.Point(132, 316);
            this.chkListDeductions.Name = "chkListDeductions";
            this.chkListDeductions.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.chkListDeductions.Size = new System.Drawing.Size(120, 49);
            this.chkListDeductions.TabIndex = 13;
            // 
            // txtRunningSalary
            // 
            this.txtRunningSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRunningSalary.Location = new System.Drawing.Point(132, 287);
            this.txtRunningSalary.Name = "txtRunningSalary";
            this.txtRunningSalary.ReadOnly = true;
            this.txtRunningSalary.Size = new System.Drawing.Size(120, 22);
            this.txtRunningSalary.TabIndex = 14;
            // 
            // txtDeductions
            // 
            this.txtDeductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeductions.Location = new System.Drawing.Point(132, 371);
            this.txtDeductions.Name = "txtDeductions";
            this.txtDeductions.ReadOnly = true;
            this.txtDeductions.Size = new System.Drawing.Size(120, 22);
            this.txtDeductions.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Current Salary";
            // 
            // txtCurrentSalary
            // 
            this.txtCurrentSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentSalary.Location = new System.Drawing.Point(132, 436);
            this.txtCurrentSalary.Name = "txtCurrentSalary";
            this.txtCurrentSalary.ReadOnly = true;
            this.txtCurrentSalary.Size = new System.Drawing.Size(120, 22);
            this.txtCurrentSalary.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tax";
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(132, 399);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(120, 22);
            this.txtTax.TabIndex = 33;
            this.txtTax.Text = "0";
            // 
            // EmployeeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 487);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCurrentSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeductions);
            this.Controls.Add(this.txtRunningSalary);
            this.Controls.Add(this.chkListDeductions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPayout);
            this.Controls.Add(this.lblHeader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EmployeeSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Salary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeSalary_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.DataGridView dgvPayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chkListDeductions;
        private System.Windows.Forms.TextBox txtRunningSalary;
        private System.Windows.Forms.TextBox txtDeductions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary_earned;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductions;
        private System.Windows.Forms.DataGridViewTextBoxColumn payout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTax;
    }
}