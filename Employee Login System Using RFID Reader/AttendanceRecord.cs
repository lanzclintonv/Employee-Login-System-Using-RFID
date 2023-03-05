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
    public partial class AttendanceRecord : Form
    {
        private bool exit = true;

        public AttendanceRecord()
        {
            InitializeComponent();
            dataRefresh();
        }

        private void dateTP_ValueChanged(object sender, EventArgs e)
        {
            dataRefreshSpecific();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            exit = false;
            FormState.PreviousPage.Show();
            this.Close();
        }

        private void AttendanceRecord_FormClosing(object sender, FormClosingEventArgs e)
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
                dataRefreshSpecific();
            }
            else
            {
                dataRefresh();
            }
        }

        private void dataRefresh()
        {
            dgvRecord.Rows.Clear();
            dgvRecord.Refresh();
            AttendanceDB adb = new AttendanceDB();
            adb.RecordList(ref dgvRecord);
        }

        private void dataRefreshSpecific()
        {
            dgvRecord.Rows.Clear();
            dgvRecord.Refresh();
            string date = dtpDate.Value.ToString("MMMM dd, yyyy");
            AttendanceDB adb = new AttendanceDB();
            adb.RecordListSpecific(ref dgvRecord, date);
        }

        private void dgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
