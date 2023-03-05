using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Employee_Login_System_Using_RFID_Reader
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGetAttendance_Click(object sender, EventArgs e)
        {
            Reset();
            (new GetAttendance()).Show();
            FormState.LoginPage = this;
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                MessageBox.Show("Please check your inputs and try again.", "One or more entries are missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (rbtnAdmin.Checked)
            {
                Admin();
            }
            else if (rbtnEmployee.Checked)
                Employee();
        }

        private bool CheckInput()
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                return false;
            else
                return true;
        }

        private void Admin()
        {
            AdminDB adb = new AdminDB();
            string username = txtUsername.Text;
            (string fname, string lname, bool match) = adb.CheckAcc(txtUsername.Text, txtPassword.Text);
            if (match)
            {
                Reset();
                (new MainMenu(username)).Show();
                FormState.LoginPage = this;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!\nPlease Try Again.", "Login Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Employee()
        {
            EmployeeDB edb = new EmployeeDB();
            (string fname, bool match) = edb.CheckAcc(txtUsername.Text, txtPassword.Text);
            string username = txtUsername.Text;
            if (match)
            {
                Reset();
                (new EmployeeMenu(username)).Show();
                FormState.LoginPage = this;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!\nPlease Try Again.", "Login Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            rbtnEmployee.Checked = true;
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
