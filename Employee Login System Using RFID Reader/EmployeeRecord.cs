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
    public partial class EmployeeRecord : Form
    {
        private bool exit = true;
        string username;

        public EmployeeRecord()
        {
            InitializeComponent();
        }

        public EmployeeRecord(string _username)
        {
            InitializeComponent();
            username = _username;
            dataRefresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            exit = false;
            FormState.PreviousPage.Show();
            this.Close();
        }

        private void EmployeeRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
            }
        }

        private void chkFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilter.Checked)
            {
                dtpDate.Enabled = true;
            }
            else
            {
                dataRefresh();
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dgvRecord.Rows.Clear();
            dgvRecord.Refresh();
            AttendanceDB adb = new AttendanceDB();
            adb.RecordListSoloSpecific(ref dgvRecord, username, dtpDate.Value.ToString("MMMM dd, yyyy"));
        }

        private void dataRefresh()
        {
            dgvRecord.Rows.Clear();
            dgvRecord.Refresh();
            AttendanceDB adb = new AttendanceDB();
            adb.RecordListSolo(ref dgvRecord, username);
        }
    }
}
