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
    public partial class EditEmployees : Form
    {
        private Socket serverSocket;
        private Socket clientSocket;
        private byte[] buffer;
        string _username;

        public EditEmployees()
        {
            InitializeComponent();
        }

        public EditEmployees(string username)
        {
            InitializeComponent();
            initializeFields(username);
            _username = username;
            StartServer();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(!(txtPassword.Text == txtRePassword.Text) && txtPassword.Text == "")
            {
                MessageBox.Show("Passwords are empty or do not match!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string pagibig = "no", philhealth = "no", sss = "no", loan = "no", cash_adv = "no";
            CheckState check1 = chkListBenefits.GetItemCheckState(0);
            CheckState check2 = chkListBenefits.GetItemCheckState(1);
            CheckState check3 = chkListBenefits.GetItemCheckState(2);
            CheckState check4 = chkListBenefits.GetItemCheckState(3);
            CheckState check5 = chkListBenefits.GetItemCheckState(4);


            if(check1 == CheckState.Checked)
            {
                pagibig = "yes";
            }
            if (check2 == CheckState.Checked)
            {
                philhealth = "yes";
            }
            if (check3 == CheckState.Checked)
            {
                sss = "yes";
            }
            if(check4 == CheckState.Checked)
            {
                loan = "yes";
            }
            if(check5 == CheckState.Checked)
            {
                cash_adv = "yes";
            }
            String base_pay = nudBasePay.Value.ToString();
            String Enpass = SimpleSecurity.Encrypt(txtPassword.Text);
            EmployeeDB edb = new EmployeeDB();
            edb.EmployeeEdit(txtLname.Text, txtFname.Text, txtMi.Text, txtAddress.Text, txtContactNo.Text,
                dateBirthday.Text, txtRFID.Text, txtUsername.Text, Enpass, pagibig, philhealth, sss, loan, base_pay, cash_adv, cbRestDay.Text);

            
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            initializeFields(_username);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxPassword.Checked)
            {
                txtRePassword.PasswordChar = '\0';
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtRePassword.PasswordChar = '*';
                txtPassword.PasswordChar = '*';
            }
        }

        private void initializeFields(string username)
        {
            EmployeeDB edb = new EmployeeDB();
            txtLname.Text =  edb.GetData(0, username);
            txtFname.Text = edb.GetData(1, username);
            txtMi.Text = edb.GetData(2, username);
            txtAddress.Text = edb.GetData(3, username);
            txtContactNo.Text = edb.GetData(4, username);
            dateBirthday.Value = DateTime.ParseExact(edb.GetData(5, username), "MMMM dd, yyyy", null);
            txtRFID.Text = edb.GetData(6, username);
            nudBasePay.Value = int.Parse(edb.GetData(15, username));
            txtUsername.Text = username;
            cbRestDay.Text = edb.GetData(17, username);

            string b1 = edb.GetData(11, username);
            if(b1 == "yes")
            {
                chkListBenefits.SetItemChecked(0, true);
            }
            else
            {
                chkListBenefits.SetItemChecked(0, false);
            }
            string b2 = edb.GetData(12, username);
            if (b2 == "yes")
            {
                chkListBenefits.SetItemChecked(1, true);
            }
            else
            {
                chkListBenefits.SetItemChecked(1, false);
            }
            string b3 = edb.GetData(13, username);
            if (b3 == "yes")
            {
                chkListBenefits.SetItemChecked(2, true);
            }
            else
            {
                chkListBenefits.SetItemChecked(2, false);
            }
            string b4 = edb.GetData(14, username);
            if (b4 == "yes")
            {
                chkListBenefits.SetItemChecked(3, true);
            }
            else
            {
                chkListBenefits.SetItemChecked(3, false);
            }
            string b5 = edb.GetData(16, username);
            if (b5 == "yes")
            {
                chkListBenefits.SetItemChecked(4, true);
            }
            else
            {
                chkListBenefits.SetItemChecked(4, false);
            }


        }

        private void EditEmployees_Load(object sender, EventArgs e)
        {
            dateBirthday.Format = DateTimePickerFormat.Custom;
            dateBirthday.CustomFormat = "MMMM dd, yyyy";
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
                string[] received = Encoding.ASCII.GetString(x).Trim('\0').Replace(System.Environment.NewLine, string.Empty).Split('/');

                txtRFID.Text = received[0];
            });
        }

        private void EditEmployees_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverSocket.Close();
        }
    }
}
