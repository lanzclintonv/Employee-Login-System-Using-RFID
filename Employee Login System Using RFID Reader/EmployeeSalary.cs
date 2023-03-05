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
    public partial class EmployeeSalary : Form
    {
        private string username;
        private bool exit = true;
        public EmployeeSalary()
        {
            InitializeComponent();
        }

        public EmployeeSalary(string _username)
        {
            InitializeComponent();
            username = _username;
            initializeFields();
            dataRefresh();
        }

        private void EmployeeSalary_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exit = false;
            FormState.PreviousPage.Show();
            this.Close();
        }

        private void dataRefresh()
        {
            dgvPayout.Rows.Clear();
            dgvPayout.Refresh();
            PayoutDB pdb = new PayoutDB();
            pdb.PayoutListSolo(ref dgvPayout, username);
        }

        private void initializeFields()
        {
            EmployeeDB edb = new EmployeeDB();
            string pagibig = edb.GetData(11, username);
            string philhealth = edb.GetData(12, username);
            string sss = edb.GetData(13, username);
            string _salary = edb.GetData(9, username);
            txtRunningSalary.Text = _salary;
            double rsalary = double.Parse(_salary);
            double d1 = 0, d2 = 0, d3 = 0;
            double csalary = 0;
            double bsalary = Double.Parse(edb.GetData(15, username));
            double tax = 0;

            if (pagibig == "yes")
            {
                chkListDeductions.SetItemChecked(0, true);
                d1 = 50;
            }
            if (philhealth == "yes")
            {
                chkListDeductions.SetItemChecked(1, true);
                d2 = rsalary * 0.03 /2;
            }
            if (sss == "yes")
            {
                chkListDeductions.SetItemChecked(2, true);
                d3 = rsalary * 0.0363 /2;
            }

            /*  Salary Computation
             *      PAGIBIG = 50
             *      PHILHEALTH 3% /2 (2020)
             *      SSS = 3.63% /2
            */

            if (bsalary <= 685)
            {
                tax = 0;
            }
            else if (bsalary > 685 && bsalary <= 1095)
            {
                tax = 0.2 * (rsalary - 685); // 0 + 20% over 685
            }
            else if (bsalary > 1095 && bsalary <= 2191)
            {
                tax = 82.19 + 0.25 * (rsalary - 1096);
            }
            else if (bsalary > 2191 && bsalary <= 5478)
            {
                tax = 356.16 + 0.3 * (rsalary - 2192);
            }
            else if (bsalary > 5478 && bsalary < 21917)
            {
                tax = 1342.47 + 0.32 * (rsalary - 5479);
            }
            else
            {
                tax = 6602.74 + 0.35 * (rsalary - 21918);
            }

            txtTax.Text = Math.Round(tax, 2).ToString();
            txtDeductions.Text = Math.Round((d1 + d2 + d3 + tax), 2).ToString();
            csalary = rsalary - d1 - d2 - d3 - tax;

            if (csalary > 0)
            {
                txtCurrentSalary.Text = csalary.ToString();
            }
            else
            {
                txtCurrentSalary.Text = "0";
            }
        }
    }
}
