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
    public partial class AddEmployees : Form
    {
        private Socket serverSocket;
        private Socket clientSocket;
        private byte[] buffer;

        public AddEmployees()
        {
            InitializeComponent();
            StartServer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeDB edb = new EmployeeDB();
            if(txtPassword.Text == txtRePassword.Text && !(txtPassword.Text == ""))
            {
                if (!edb.RFIDCheck(txtRFID.Text))
                {
                    string base_pay = nudBasePay.Value.ToString();
                    string Enpass = SimpleSecurity.Encrypt(txtPassword.Text);
                    bool success = edb.EmployeeAdd(txtLname.Text, txtFname.Text, txtMi.Text, txtAddress.Text,
                    txtContactNo.Text, dateBirthday.Text, txtRFID.Text, txtUsername.Text, Enpass, base_pay);
                    if (success)
                    {
                        MessageBox.Show("Employee Registered Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("RFID Code Already Taken", "Please choose a different RFID!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match!", "Check your credentials!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset()
        {
            txtAddress.Text = "";
            txtContactNo.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtMi.Text = "";
            txtPassword.Text = "";
            txtRePassword.Text = "";
            txtRFID.Text = "";
            txtUsername.Text = "";
            dateBirthday.Value = Convert.ToDateTime("01/01/1990");
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

        private void AddEmployees_Load(object sender, EventArgs e)
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

        

        private void AddEmployees_FormClosing(object sender, FormClosingEventArgs e)
        {
            //serverSocket.Shutdown(SocketShutdown.Both);
            serverSocket.Close();
        }
    }
}
