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
    public partial class ManageEmployees : Form
    {

        private bool exit = true;

        public ManageEmployees()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();
            exit = false;
            this.Close();
        }

        private void ManageEmployees_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
                Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new AddEmployees()).ShowDialog();
            dataRefresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string username;
            try
            {
                username = dgvEmployees.Rows[dgvEmployees.CurrentCell.RowIndex].Cells[7].Value.ToString();
            }
            catch (NullReferenceException)
            {
                System.Windows.Forms.MessageBox.Show("Unable to perform edit to any user!", "Database Empty",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            
            (new EditEmployees(username)).ShowDialog();
            dataRefresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = "";
            try
            {
                username = dgvEmployees.Rows[dgvEmployees.CurrentCell.RowIndex].Cells[7].Value.ToString();
            }
            catch(NullReferenceException)
            {
                System.Windows.Forms.MessageBox.Show("Unable to perform delete to any user!", "Database Empty",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this employee from the" +
                "database?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                return;
            }
            EmployeeDB edb = new EmployeeDB();
            edb.EmployeeDelete(username);
            dataRefresh();
        }

        private void ManageEmployees_Load(object sender, EventArgs e)
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
            if(txtSearch.Text == "")
            {
                dataRefresh();
            }
        }
    }
}
