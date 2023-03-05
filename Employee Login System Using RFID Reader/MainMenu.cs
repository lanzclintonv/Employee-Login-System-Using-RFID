using Microsoft.Office.Interop.Access.Dao;
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
    public partial class MainMenu : Form
    {
        private bool exit = true;
        public string _username = "";
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(string username)
        {
            InitializeComponent();
            _username = username;
            AdminDB adb = new AdminDB();
            lblGreetings.Text += adb.GetData(2, username) + " " + adb.GetData(3, username) + "!";
            if(username != "admin")
            {
                btnManageAdmin.Enabled = false;
            }
        }

        public MainMenu(string fname, string lname)
        {
            InitializeComponent();
            lblGreetings.Text += fname + " " + lname + "!";
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
                Application.Exit();
        }

        //Buttons
        #region
        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormState.LoginPage.Show();
            exit = false;
            this.Close();
        }

        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            (new ManageEmployees()).Show();
            this.Hide();
        }

        private void btnAttendanceRecord_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            (new AttendanceRecord()).Show();
            this.Hide();
        }

        private void btnViewSalary_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            (new ViewSalary()).Show();
            this.Hide();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            (new ExportToExcel()).Show();
            this.Hide();
        }

        private void btnManageAdmin_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            (new ManageAdmins()).Show();
            this.Hide();
        }

        private void btnSalaryControl_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            (new SalaryControl(_username)).Show();
            this.Hide();
        }

        private void btnGeneratePayslip_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            (new GeneratePayslip()).Show();
            this.Hide();
        }

        private void btnAdjustVariables_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            (new Variables()).Show();
            this.Hide();
        }

        #endregion

        private void btnLeaveAdjustment_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage = this;
            (new LeaveAdjustment()).Show();
            this.Hide();
        }
    }
}
