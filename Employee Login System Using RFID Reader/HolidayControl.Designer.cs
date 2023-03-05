namespace Employee_Login_System_Using_RFID_Reader
{
    partial class HolidayControl
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
            this.dgvHoliday = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dtpHoliday = new System.Windows.Forms.DateTimePicker();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.rbSpecial = new System.Windows.Forms.RadioButton();
            this.rbDouble = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoliday)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoliday
            // 
            this.dgvHoliday.AllowUserToAddRows = false;
            this.dgvHoliday.AllowUserToDeleteRows = false;
            this.dgvHoliday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoliday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.hdate,
            this.type});
            this.dgvHoliday.Location = new System.Drawing.Point(12, 30);
            this.dgvHoliday.Name = "dgvHoliday";
            this.dgvHoliday.ReadOnly = true;
            this.dgvHoliday.Size = new System.Drawing.Size(331, 160);
            this.dgvHoliday.TabIndex = 0;
            // 
            // no
            // 
            this.no.HeaderText = "No.";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 50;
            // 
            // hdate
            // 
            this.hdate.HeaderText = "Date";
            this.hdate.Name = "hdate";
            this.hdate.ReadOnly = true;
            this.hdate.Width = 150;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.Location = new System.Drawing.Point(12, 9);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(100, 18);
            this.lblHeader1.TabIndex = 9;
            this.lblHeader1.Text = "Holiday List";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 297);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(268, 297);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dtpHoliday
            // 
            this.dtpHoliday.Location = new System.Drawing.Point(15, 196);
            this.dtpHoliday.Name = "dtpHoliday";
            this.dtpHoliday.Size = new System.Drawing.Size(328, 20);
            this.dtpHoliday.TabIndex = 13;
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Checked = true;
            this.rbRegular.Location = new System.Drawing.Point(15, 223);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(62, 17);
            this.rbRegular.TabIndex = 14;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Regular";
            this.rbRegular.UseVisualStyleBackColor = true;
            // 
            // rbSpecial
            // 
            this.rbSpecial.AutoSize = true;
            this.rbSpecial.Location = new System.Drawing.Point(15, 247);
            this.rbSpecial.Name = "rbSpecial";
            this.rbSpecial.Size = new System.Drawing.Size(60, 17);
            this.rbSpecial.TabIndex = 15;
            this.rbSpecial.Text = "Special";
            this.rbSpecial.UseVisualStyleBackColor = true;
            // 
            // rbDouble
            // 
            this.rbDouble.AutoSize = true;
            this.rbDouble.Location = new System.Drawing.Point(15, 270);
            this.rbDouble.Name = "rbDouble";
            this.rbDouble.Size = new System.Drawing.Size(59, 17);
            this.rbDouble.TabIndex = 16;
            this.rbDouble.Text = "Double";
            this.rbDouble.UseVisualStyleBackColor = true;
            // 
            // HolidayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 332);
            this.Controls.Add(this.rbDouble);
            this.Controls.Add(this.rbSpecial);
            this.Controls.Add(this.rbRegular);
            this.Controls.Add(this.dtpHoliday);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblHeader1);
            this.Controls.Add(this.dgvHoliday);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "HolidayControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holiday Control";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoliday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoliday;
        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DateTimePicker dtpHoliday;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.RadioButton rbRegular;
        private System.Windows.Forms.RadioButton rbSpecial;
        private System.Windows.Forms.RadioButton rbDouble;
    }
}