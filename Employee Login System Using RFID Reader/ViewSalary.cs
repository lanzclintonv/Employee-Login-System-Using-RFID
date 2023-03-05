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
    public partial class ViewSalary : Form
    {
        private bool exit = true;

        public ViewSalary()
        {
            InitializeComponent();
            dataRefresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            exit = false;
            FormState.PreviousPage.Show();
            this.Close();
        }

        private void ViewSalary_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
                Application.Exit();
        }

        private void dataRefresh()
        {
            dgvSalary.Rows.Clear();
            dgvSalary.Refresh();
            EmployeeDB edb = new EmployeeDB();
            edb.EmployeeListSalary(ref dgvSalary);
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
                case "":
                    break;
            }
            dgvSalary.Rows.Clear();
            dgvSalary.Refresh();
            EmployeeDB edb = new EmployeeDB();
            if (txtSearch.Text == "" || cboxFilter.Text == "")
            {
                edb.EmployeeList(ref dgvSalary);
            }
            else
            {
                edb.EmployeeListSpecific(ref dgvSalary, filter, index);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dataRefresh();
            }
        }
    }
}
