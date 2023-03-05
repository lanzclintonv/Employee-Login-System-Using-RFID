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
    public partial class GetAttendance : Form
    {
        private Socket serverSocket;
        private Socket clientSocket;
        private byte[] buffer;
        private bool exit = true;

        public GetAttendance()
        {
            InitializeComponent();
            StartServer();
            dataRefresh();
            txtTime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormState.LoginPage.Show();
            exit = false;
            this.Close();
        }

        private void GetAttendance_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverSocket.Close();
            if (exit)
                Application.Exit();
        }

        private void GetAttendance_Load(object sender, EventArgs e)
        {
            //lblDate.Text = DateTime.Now.ToLongDateString();
            
        }

        private void realTime_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("HH:mm");
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
                string lname, fname, mi = "";
                string time_now = txtTime.Text;
                string date = dtpNow.Value.ToString("MMMM dd, yyyy");
                string yesterday = dtpNow.Value.AddDays(-1).ToString("MMMM dd, yyyy");
                string rest_day = dtpNow.Value.ToString("dddd");
                lname = edb.GetDataRFID(0, rfid);
                fname = edb.GetDataRFID(1, rfid);
                mi = edb.GetDataRFID(2, rfid);
                mi = edb.GetDataRFID(2, rfid);
                string[] t = time_now.Split(':');
                int h = int.Parse(t[0]);
                int m = int.Parse(t[1]);
                if (lname == "" && fname == "" && mi == "")
                {
                    MessageBox.Show("RFID not found in database!");
                    return;
                }
                AttendanceDB adb = new AttendanceDB();
                bool found = adb.isTimeIn(date, rfid);
                bool found2 = adb.isTimeOut(yesterday, rfid);
                bool found3 = adb.isTimeIn(yesterday, rfid);
                if (!found) //Not Timed In Today
                {
                    if (!found2 && found3) // Not Timed Out Yesterday AND Timed In Yesterday
                    {
                        adb.TimeOut(yesterday, rfid, time_now, rest_day);
                        MessageBox.Show("Night Shift Detected! Time Out Placed On Previous Day!");
                    }
                    else
                    {
                        adb.TimeIn(lname, fname, mi, date, time_now, rfid);
                    }

                }
                else //Timed In Today
                {
                    adb.TimeOut(date, rfid, time_now, rest_day);
                }
                dataRefresh();
            });
        }

        private void dataRefresh()
        {
            dgvAttendanceRecord.Rows.Clear();
            dgvAttendanceRecord.Refresh();
            AttendanceDB adb = new AttendanceDB();
            adb.RecordListSpecific2(ref dgvAttendanceRecord, dtpNow.Value.ToString("MMMM dd, yyyy"));
        }

        private void dtpNow_ValueChanged(object sender, EventArgs e)
        {
            dataRefresh();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            EmployeeDB edb = new EmployeeDB();
            string[] received = txtRFID.Text.Trim('\0').Replace(System.Environment.NewLine, string.Empty).Split('/');
            string rfid = received[0];
            string lname, fname, mi = "";
            string time_now = txtTime.Text;
            string date = dtpNow.Value.ToString("MMMM dd, yyyy");
            string yesterday = dtpNow.Value.AddDays(-1).ToString("MMMM dd, yyyy");
            string rest_day = dtpNow.Value.ToString("dddd");
            lname = edb.GetDataRFID(0, rfid);
            fname = edb.GetDataRFID(1, rfid);
            mi = edb.GetDataRFID(2, rfid);
            string[] t = time_now.Split(':');
            int h = int.Parse(t[0]);
            int m = int.Parse(t[1]);
            if (lname == "" && fname == "" && mi == "")
            {
                MessageBox.Show("RFID not found in database!");
                return;
            }
            AttendanceDB adb = new AttendanceDB();
            bool found = adb.isTimeIn(date, rfid);
            bool found2 = adb.isTimeOut(yesterday, rfid);
            bool found3 = adb.isTimeIn(yesterday, rfid);
            if (!found) //Not Timed In Today
            {
                if (!found2 && found3) // Not Timed Out Yesterday AND Timed In Yesterday
                {
                    adb.TimeOut(yesterday, rfid, time_now, rest_day);
                    MessageBox.Show("Night Shift Detected! Time Out Placed On Previous Day!");
                }
                else
                {
                    adb.TimeIn(lname, fname, mi, date, time_now, rfid);
                }
               
            }
            else //Timed In Today
            {
                adb.TimeOut(date, rfid, time_now, rest_day);
            }
            dataRefresh();
        }
    }
}
