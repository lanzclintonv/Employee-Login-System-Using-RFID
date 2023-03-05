using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Login_System_Using_RFID_Reader
{
    public partial class GeneratePayslip : Form
    {

        private bool exit = true;

        public GeneratePayslip()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            exit = false;
            this.Close();
        }

        private void GeneratePayslip_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
                Application.Exit();
        }


        private void GeneratePayslip_Load(object sender, EventArgs e)
        {
            dataRefresh();
        }

        private void dataRefresh()
        {
            dgvEmployees.Rows.Clear();
            dgvEmployees.Refresh();
            EmployeeDB edb = new EmployeeDB();
            edb.EmployeeList(ref dgvEmployees);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = 0;
            string filter = txtSearch.Text;
            switch (cboxFilter.Text)
            {
                case "Last Name":
                    index = 0;
                    break;
                case "First Name":
                    index = 1;
                    break;
                case "RFID":
                    index = 6;
                    break;
                case "Username":
                    index = 7;
                    break;
                case "":
                    break;
            }
            dgvEmployees.Rows.Clear();
            dgvEmployees.Refresh();
            EmployeeDB edb = new EmployeeDB();
            if (txtSearch.Text == "" || cboxFilter.Text == "")
            {
                edb.EmployeeList(ref dgvEmployees);
            }
            else
            {
                edb.EmployeeListSpecific(ref dgvEmployees, filter, index);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dataRefresh();
            }
        }

        private void btnGeneratePayslip_Click(object sender, EventArgs e)
        {
            string rfid;
            try
            {
                rfid = dgvEmployees.Rows[dgvEmployees.CurrentCell.RowIndex].Cells[6].Value.ToString();
            }
            catch (NullReferenceException)
            {
                System.Windows.Forms.MessageBox.Show("Unable to perform edit to any user!", "Database Empty",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            (new Payslip(rfid)).ShowDialog();
        }
    }
}
