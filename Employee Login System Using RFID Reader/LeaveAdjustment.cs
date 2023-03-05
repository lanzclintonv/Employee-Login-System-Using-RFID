using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Employee_Login_System_Using_RFID_Reader
{
    public partial class LeaveAdjustment : Form
    {
        private Socket serverSocket;
        private Socket clientSocket;
        private byte[] buffer;
        private bool exit = false;

        public LeaveAdjustment()
        {
            StartServer();
            InitializeComponent();
            dataRefresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            exit = false;
            FormState.PreviousPage.Show();
            this.Close();
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

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dataRefreshSpecific();
        }

        private void chkFilter_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkFilter.Checked)
            {
                dtpDate.Enabled = true;
                dataRefreshSpecific();
            }
            else
            {
                dtpDate.Enabled = false;
                dtpDate.Value = DateTime.Now;
                dataRefresh();
            }
        }

        private void LeaveAdjustment_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverSocket.Close();
            if (exit)
                Application.Exit();
        }

        private static void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void StartServer()
        {
            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(IPAddress.Any, 2000));
                serverSocket.Listen(10);
                serverSocket.BeginAccept(AcceptCallback, null);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void AcceptCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket = serverSocket.EndAccept(AR);
                buffer = new byte[clientSocket.ReceiveBufferSize];

                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
                serverSocket.BeginAccept(AcceptCallback, null);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                //
            }
        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            try
            {
                int received = clientSocket.EndReceive(AR);

                if (received == 0)
                {
                    return;
                }

                SubmitPersonToDataGrid(buffer);

                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);

            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {

            }
        }

        private void SubmitPersonToDataGrid(byte[] x)
        {
            Invoke((Action)delegate
            {
                EmployeeDB edb = new EmployeeDB();
                string[] received = Encoding.ASCII.GetString(x).Trim('\0').Replace(System.Environment.NewLine, string.Empty).Split('/');
                string rfid = received[0];
                string lname, fname, mi;

                txtRFID.Text = rfid;
                lname = edb.GetDataRFID(0, rfid);
                fname = edb.GetDataRFID(1, rfid);
                mi = edb.GetDataRFID(2, rfid);
                txtName.Text =  lname + ", " + fname + " " + mi + ".";
                txtBasePay.Text = edb.GetDataRFID(15, rfid);
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpDate.Enabled = false;
            dtpDate.Value = DateTime.Now;
            dataRefresh();
            chkFilter.Checked = false;
            txtRFID.Text = "";
            txtName.Text = "";
            txtBasePay.Text = "";
        }

        private void btnSickLeave_Click(object sender, EventArgs e)
        {
            EmployeeDB edb = new EmployeeDB();
            AttendanceDB adb = new AttendanceDB();
            if (!edb.RFIDCheck(txtRFID.Text))
            {
                MessageBox.Show("No Employee Has Been Found With This RFID!", "Please choose a different RFID!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            string lname, fname, mi;
            string rfid = txtRFID.Text;
            lname = edb.GetDataRFID(0, rfid);
            fname = edb.GetDataRFID(1, rfid);
            mi = edb.GetDataRFID(2, rfid);
            bool leave_type = false; //false = SL true = VL
            if(rbtnVacation.Checked == true)
            {
                leave_type = true;
            }
            else if(rbtnSick.Checked == true)
            {
                leave_type = false;
            }
            string date = dtpDate.Value.ToString("MMMM dd, yyyy");

            bool found = adb.isTimeIn(date, txtRFID.Text);

            if (found)
            {
                MessageBox.Show("Employee Timed In This Day!", "Please choose a different date!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else if (rfid == "6870301")
            {
                MessageBox.Show("Employee reached maximum leave allowed!", "Unable to set leave", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                adb.SetLeave(leave_type, txtRFID.Text, lname, fname, mi, date, txtBasePay.Text);
                MessageBox.Show("Leave Set Successfully!");
                dataRefreshSpecific();
                txtRFID.Text = "";
                txtName.Text = "";
                txtBasePay.Text = "";
            }
            
        }
    }
}
