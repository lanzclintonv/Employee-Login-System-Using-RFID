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
    public partial class EmployeeMenu : Form
    {
        private string username;
        private bool exit = true;
        public EmployeeMenu()
        {
            InitializeComponent();
        }

        public EmployeeMenu(string _username)
        {
            InitializeComponent();
            username = _username;
            EmployeeDB edb = new EmployeeDB();
            string fname = edb.GetData(1, _username);
            lblGreetings.Text += " " + fname;
        }

        private void btnAttendanceRecord_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            (new EmployeeRecord(username)).Show();
            this.Hide();
        }

        private void btnViewSalary_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            (new EmployeeSalary(username)).Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            exit = false;
            FormState.LoginPage.Show();
            this.Close();
        }

        private void EmployeeMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
            }
        }
    }
}
