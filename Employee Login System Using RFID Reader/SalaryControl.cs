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
    public partial class SalaryControl : Form
    {
        public bool exit = true;
        private string _rfid = "";
        public bool noDigits = true;
        public double deductions = 0;
        public double _bsalary = 0;
        public SalaryControl()
        {
            InitializeComponent();
            dataRefresh();
            ShowHolidays();
            VariablesDB vdb = new VariablesDB();
            lblOtherLoan.Text = vdb.GetData(1) + " Loan";
        }

        public SalaryControl(string username)
        {
            InitializeComponent();
            dataRefresh();
            ShowHolidays();
            VariablesDB vdb = new VariablesDB();
            lblOtherLoan.Text = vdb.GetData(1) + " Loan";
            if (username != "admin")
            {
                btnPayout.Enabled = false;
                txtPagibigLoan.Enabled = false;
                txtSSSLoan.Enabled = false;
                txtLoan.Enabled = false;
                txtCashAdv.Enabled = false;
                txtIncentive.Enabled = false;
            }
        }

        private void SalaryControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            exit = false;
            FormState.PreviousPage.Show();
            this.Close();
        }

        private void dgvPayout_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clear();
            string rfid = dgvPayout.Rows[dgvPayout.CurrentCell.RowIndex].Cells[3].Value.ToString();
            _rfid = rfid;
            EmployeeDB edb = new EmployeeDB();
            string pagibig = edb.GetDataRFID(11, rfid);
            string philhealth = edb.GetDataRFID(12, rfid);
            string sss = edb.GetDataRFID(13, rfid);
            string loan = edb.GetDataRFID(14, rfid);
            string cash_adv = edb.GetDataRFID(16, rfid);
            string _salary = edb.GetDataRFID(9, rfid);
            txtRunningSalary.Text = _salary;
            double rsalary = double.Parse(_salary);
            double d1 = 0, d2 = 0, d3 = 0, d4 = 0, d5 = 0;
            double csalary = 0;
            double bsalary = Double.Parse(edb.GetDataRFID(15, rfid));
            _bsalary = bsalary;
            double tax = 0;
            VariablesDB vdb = new VariablesDB();
            //Deduction Rates
            double rate_pagibig = double.Parse(vdb.GetData(2));
            double rate_philhealth = double.Parse(vdb.GetData(3));
            double rate_sss = double.Parse(vdb.GetData(4));

            if (pagibig == "yes")
            {
                chkListDeductions.SetItemChecked(0, true);
                d1 = rsalary * rate_pagibig / 2;
                d1 = Math.Round(d1, 2);
                if (d1 > 50)
                {
                    d1 = 50;
                }
            }
            else
            {
                chkListDeductions.SetItemChecked(0, false);
            }
            if (philhealth == "yes")
            {
                chkListDeductions.SetItemChecked(1, true);
                d2 = rsalary * rate_philhealth / 2;
                d2 = Math.Round(d2, 2);
            }
            else
            {
                chkListDeductions.SetItemChecked(1, false);
            }
            if (sss == "yes")
            {
                chkListDeductions.SetItemChecked(2, true);
                d3 = rsalary * rate_sss / 2;
                d3 = Math.Round(d3, 2);
            }
            else
            {
                chkListDeductions.SetItemChecked(2, false);
            }

            txtPagibig.Text = d1.ToString();
            txtPhilhealth.Text = d2.ToString();
            txtSSS.Text = d3.ToString();

            if (loan == "yes")
            {
                chkListDeductions.SetItemChecked(3, true);
                txtPagibigLoan.ReadOnly = false;
                txtSSSLoan.ReadOnly = false;
                txtLoan.ReadOnly = false;
                txtPagibigLoan.Text = "0";
                txtSSSLoan.Text = "0";
                txtLoan.Text = "0";

                d4 = double.Parse(txtLoan.Text);
            }
            else
            {
                chkListDeductions.SetItemChecked(3, false);
                txtPagibigLoan.ReadOnly = true;
                txtSSSLoan.ReadOnly = true;
                txtLoan.ReadOnly = true;
            }
            if (cash_adv == "yes")
            {
                chkListDeductions.SetItemChecked(4, true);
                txtCashAdv.ReadOnly = false;
                txtCashAdv.Text = "0";
                d5 = double.Parse(txtLoan.Text);
            }
            else
            {
                chkListDeductions.SetItemChecked(4, false);
                txtCashAdv.ReadOnly = true;
            }

            //Tax Variables
            double t1 = double.Parse(vdb.GetData(5));
            double t2 = double.Parse(vdb.GetData(6));
            double t3 = double.Parse(vdb.GetData(7));
            double t4 = double.Parse(vdb.GetData(8));
            double t5 = double.Parse(vdb.GetData(9));
            double r1 = double.Parse(vdb.GetData(10));
            double r2 = double.Parse(vdb.GetData(11));
            double r3 = double.Parse(vdb.GetData(12));
            double r4 = double.Parse(vdb.GetData(13));
            double r5 = double.Parse(vdb.GetData(14));
            double c1 = double.Parse(vdb.GetData(15));
            double c2 = double.Parse(vdb.GetData(16));
            double c3 = double.Parse(vdb.GetData(17));
            double c4 = double.Parse(vdb.GetData(18));
            double c5 = double.Parse(vdb.GetData(19));

            bsalary = bsalary * 15;

            if (bsalary <= t1)
            {
                tax = 0;
            }
            else if (bsalary > t1 && bsalary <= t2)
            {
                tax = c1 + r1 * (rsalary - (t1 + 1)); // 0 + 20% over 685
            }
            else if (bsalary > t2 && bsalary <= t3)
            {
                tax = c2 + r2 * (rsalary - (t2 + 1));
            }
            else if (bsalary > t3 && bsalary <= t4)
            {
                tax = c3 + r3 * (rsalary - (t3 + 1));
            }
            else if (bsalary > t4 && bsalary < t5)
            {
                tax = c4 + r4 * (rsalary - (t4 + 1));
            }
            else
            {
                tax = c5 + r5 * (rsalary - (t5 + 1));
            }

            txtTax.Text = Math.Round(tax, 2).ToString();
            double d = Math.Round(d1 + d2 + d3 + d4 + d5 + tax, 2);
            deductions = Math.Round(d1 + d2 + d3 + d4 + d5, 2);
            txtDeductions.Text = d.ToString();
            csalary = rsalary - d1 - d2 - d3 - d4 - tax;
            csalary = Math.Round(csalary, 2);
            if (csalary > 0)
            {
                txtCurrentSalary.Text = csalary.ToString();
            }
            else
            {
                txtCurrentSalary.Text = "0";
            }
        }

        private void dataRefresh()
        {
            dgvPayout.Rows.Clear();
            dgvPayout.Refresh();
            EmployeeDB edb = new EmployeeDB();
            edb.EmployeeListPayout(ref dgvPayout);
        }

        private void clear()
        {
            txtCurrentSalary.Text = "0";
            txtDeductions.Text = "0";
            txtRunningSalary.Text = "0";
            txtLoan.Text = "0";
            txtTax.Text = "0";
            txtPagibigLoan.Text = "0";
            txtSSSLoan.Text = "0";
            txtPagibig.Text = "0";
            txtPhilhealth.Text = "0";
            txtSSS.Text = "0";
            txtIncentive.Text = "0";
            chkListDeductions.SetItemChecked(0, false);
            chkListDeductions.SetItemChecked(1, false);
            chkListDeductions.SetItemChecked(2, false);
            chkListDeductions.SetItemChecked(3, false);
            chkListDeductions.SetItemChecked(4, false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataRefresh();
            clear();
        }

        private void btnPayout_Click(object sender, EventArgs e)
        {
            if (txtCurrentSalary.Text == "" || _rfid == "")
            {
                MessageBox.Show("Please Choose An Employee To Payout!");
                return;
            }
            if(noDigits == false)
            {
                MessageBox.Show("Please Check ");
                return;
            }
            double p = double.Parse(txtCurrentSalary.Text);
            if (p <= 0)
            {
                MessageBox.Show("Unable to Payout! Cash Advance or Loan Cannot Exceed Running Salary");
                return;
            }
            EmployeeDB edb = new EmployeeDB();
            AttendanceDB adb = new AttendanceDB();
            string lname = edb.GetDataRFID(0, _rfid);
            string fname = edb.GetDataRFID(1, _rfid);
            string mi = edb.GetDataRFID(2, _rfid);
            string username = edb.GetDataRFID(7, _rfid);
            string rfid = _rfid;
            string from = edb.GetDataRFID(10, _rfid);
            //string to = DateTime.Now.ToString("MMMM dd, yyyy");
            string to = adb.FindLatestDate(from, rfid);
            string salary_earned = txtRunningSalary.Text;
            string deduction = txtDeductions.Text;
            string payout = txtCurrentSalary.Text;
            string pagibig = txtPagibig.Text;
            string philhealth = txtPhilhealth.Text;
            string sss = txtSSS.Text;
            string pagibig_loan = txtPagibigLoan.Text;
            string sss_loan = txtSSSLoan.Text;
            string other_loan = txtLoan.Text;
            string tax = txtTax.Text;
            string cash_adv = txtCashAdv.Text;
            string incentive = txtIncentive.Text;

            PayoutDB pdb = new PayoutDB();
            pdb.AddPayout(lname, fname, mi, username, rfid, from, to, salary_earned, deduction, payout,
                pagibig, philhealth, sss, pagibig_loan, sss_loan, other_loan, tax,
                cash_adv, incentive);
            edb.UpdateRefDate(_rfid, to);
            edb.ResetSalary(_rfid);

            MessageBox.Show("Payout Successfull!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clear();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            (new HolidayControl()).ShowDialog();
            ShowHolidays();
        }

        private void ShowHolidays()
        {
            lbxHoliday.Items.Clear();
            lbxHoliday.Refresh();
            HolidayDB hdb = new HolidayDB();
            hdb.HolidayMark(ref lbxHoliday);
        }

        private void TxtLoan_TextChanged(object sender, EventArgs e)
        {
            double rsalary = double.Parse(txtRunningSalary.Text);
            double tax = double.Parse(txtTax.Text);
            double pagibig_loan, sss_loan, loan, cash_adv, incentive;
            double d = deductions;
            double csalary, tsalary;

            if (!Double.TryParse(txtPagibigLoan.Text, out pagibig_loan))
            {
                pagibig_loan = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtSSSLoan.Text, out sss_loan))
            {
                sss_loan = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtLoan.Text, out loan))
            {
                loan = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtCashAdv.Text, out cash_adv))
            {
                cash_adv = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtIncentive.Text, out incentive))
            {
                incentive = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            tsalary = rsalary + incentive;
            tax = Taxes(_bsalary, tsalary);
            txtTax.Text = tax.ToString();
            d = d + pagibig_loan + sss_loan + loan + cash_adv + tax;
            csalary = rsalary - d + incentive;
            Math.Round(csalary, 2);
            Math.Round(d, 2);
            if (csalary > 0)
            {
                txtCurrentSalary.Text = csalary.ToString();
            }
            else
            {
                txtCurrentSalary.Text = "0";
            }
            txtDeductions.Text = d.ToString();
        }

        private void txtCashAdv_TextChanged(object sender, EventArgs e)
        {
            double rsalary = double.Parse(txtRunningSalary.Text);
            double tax = double.Parse(txtTax.Text);
            double pagibig_loan, sss_loan, loan, cash_adv, incentive;
            double d = deductions;
            double csalary, tsalary;

            if (!Double.TryParse(txtPagibigLoan.Text, out pagibig_loan))
            {
                pagibig_loan = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtSSSLoan.Text, out sss_loan))
            {
                sss_loan = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtLoan.Text, out loan))
            {
                loan = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtCashAdv.Text, out cash_adv))
            {
                cash_adv = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtIncentive.Text, out incentive))
            {
                incentive = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            tsalary = rsalary + incentive;
            tax = Taxes(_bsalary, tsalary);
            txtTax.Text = tax.ToString();
            d = d + pagibig_loan + sss_loan + loan + cash_adv + tax;
            csalary = rsalary - d + incentive;
            Math.Round(csalary, 2);
            Math.Round(d, 2);
            if (csalary > 0)
            {
                txtCurrentSalary.Text = csalary.ToString();
            }
            else
            {
                txtCurrentSalary.Text = "0";
            }
            txtDeductions.Text = d.ToString();
        }

        private void txtIncentive_TextChanged(object sender, EventArgs e)
        {
            double rsalary = double.Parse(txtRunningSalary.Text);
            double tax = double.Parse(txtTax.Text);
            double pagibig_loan, sss_loan, loan, cash_adv, incentive;
            double d = deductions;
            double csalary, tsalary;

            if (!Double.TryParse(txtPagibigLoan.Text, out pagibig_loan))
            {
                pagibig_loan = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtSSSLoan.Text, out sss_loan))
            {
                sss_loan = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtLoan.Text, out loan))
            {
                loan = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtCashAdv.Text, out cash_adv))
            {
                cash_adv = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtIncentive.Text, out incentive))
            {
                incentive = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            tsalary = rsalary + incentive;
            tax = Taxes(_bsalary, tsalary);
            txtTax.Text = tax.ToString();
            d = d + pagibig_loan + sss_loan + loan + cash_adv + tax;
            csalary = rsalary - d + incentive;
            Math.Round(csalary, 2);
            Math.Round(d, 2);
            if (csalary > 0)
            {
                txtCurrentSalary.Text = csalary.ToString();
            }
            else
            {
                txtCurrentSalary.Text = "0";
            }
            txtDeductions.Text = d.ToString();
        }

        private void txtPagibigLoan_TextChanged(object sender, EventArgs e)
        {
            double rsalary = double.Parse(txtRunningSalary.Text);
            double tax = double.Parse(txtTax.Text);
            double pagibig_loan, sss_loan, loan, cash_adv, incentive;
            double d = deductions;
            double csalary, tsalary;

            if (!Double.TryParse(txtPagibigLoan.Text, out pagibig_loan))
            {
                pagibig_loan = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtSSSLoan.Text, out sss_loan))
            {
                sss_loan = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtLoan.Text, out loan))
            {
                loan = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtCashAdv.Text, out cash_adv))
            {
                cash_adv = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtIncentive.Text, out incentive))
            {
                incentive = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            tsalary = rsalary + incentive;
            tax = Taxes(_bsalary, tsalary);
            txtTax.Text = tax.ToString();
            d = d + pagibig_loan + sss_loan + loan + cash_adv + tax;
            csalary = rsalary - d + incentive;
            Math.Round(csalary, 2);
            Math.Round(d, 2);
            if (csalary > 0)
            {
                txtCurrentSalary.Text = csalary.ToString();
            }
            else
            {
                txtCurrentSalary.Text = "0";
            }
            txtDeductions.Text = d.ToString();
        }

        private void txtSSSLoan_TextChanged(object sender, EventArgs e)
        {
            double rsalary = double.Parse(txtRunningSalary.Text);
            double tax = double.Parse(txtTax.Text);
            double pagibig_loan, sss_loan, loan, cash_adv, incentive;
            double d = deductions;
            double csalary, tsalary;

            if (!Double.TryParse(txtPagibigLoan.Text, out pagibig_loan))
            {
                pagibig_loan = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtSSSLoan.Text, out sss_loan))
            {
                sss_loan = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtLoan.Text, out loan))
            {
                loan = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtCashAdv.Text, out cash_adv))
            {
                cash_adv = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            if (!Double.TryParse(txtIncentive.Text, out incentive))
            {
                incentive = 0;
                noDigits = false;
            }
            else
            {
                noDigits = true;
            }
            tsalary = rsalary + incentive;
            tax = Taxes(_bsalary, tsalary);
            txtTax.Text = tax.ToString();
            d = d + pagibig_loan + sss_loan + loan + cash_adv + tax;
            csalary = rsalary - d + incentive;
            Math.Round(csalary, 2);
            Math.Round(d, 2);
            if (csalary > 0)
            {
                txtCurrentSalary.Text = csalary.ToString();
            }
            else
            {
                txtCurrentSalary.Text = "0";
            }
            txtDeductions.Text = d.ToString();
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if ((c < '0' || c > '9') && c != '.')
                    return false;
            }

            return true;
        }

        double Taxes(double bsalary, double rsalary)
        {
            double tax = 0;
            VariablesDB vdb = new VariablesDB();

            double t1 = double.Parse(vdb.GetData(5));
            double t2 = double.Parse(vdb.GetData(6));
            double t3 = double.Parse(vdb.GetData(7));
            double t4 = double.Parse(vdb.GetData(8));
            double t5 = double.Parse(vdb.GetData(9));
            double r1 = double.Parse(vdb.GetData(10));
            double r2 = double.Parse(vdb.GetData(11));
            double r3 = double.Parse(vdb.GetData(12));
            double r4 = double.Parse(vdb.GetData(13));
            double r5 = double.Parse(vdb.GetData(14));
            double c1 = double.Parse(vdb.GetData(15));
            //double c1 = 0;
            double c2 = double.Parse(vdb.GetData(16));
            double c3 = double.Parse(vdb.GetData(17));
            double c4 = double.Parse(vdb.GetData(18));
            double c5 = double.Parse(vdb.GetData(19));

            if (bsalary <= t1)
            {
                tax = 0;
            }
            else if (bsalary > t1 && bsalary <= t2)
            {
                tax = c1 + r1 * (rsalary - (t1 + 1)); // 0 + 20% over 685
            }
            else if (bsalary > t2 && bsalary <= t3)
            {
                tax = c2 + r2 * (rsalary - (t2 + 1));
            }
            else if (bsalary > t3 && bsalary <= t4)
            {
                tax = c3 + r3 * (rsalary - (t3 + 1));
            }
            else if (bsalary > t4 && bsalary < t5)
            {
                tax = c4 + r4 * (rsalary - (t4 + 1));
            }
            else
            {
                tax = c5 + r5 * (rsalary - (t5 + 1));
            }
            tax = Math.Round(tax, 2);
            return tax;
        }
    }
}
