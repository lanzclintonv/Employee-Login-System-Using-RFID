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
    public partial class Payslip : Form
    {
        EmployeeDB edb = new EmployeeDB();
        string rfid;

        public Payslip()
        {
            InitializeComponent();
            lblCDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        public Payslip(string _rfid)
        {
            InitializeComponent();
            rfid = _rfid;
           
            //Initialize
            lblName.Text =  edb.GetDataRFID(0, rfid) + ", " + edb.GetDataRFID(1, rfid) + " " + edb.GetDataRFID(2, rfid) + ".";
            lblRFID.Text = _rfid;
            lblRate.Text = edb.GetDataRFID(15, rfid);
            lblADate.Text = edb.GetDataRFID(10, rfid);
            lblCDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            //Data
            string pagibig = edb.GetDataRFID(11, rfid);
            string philhealth = edb.GetDataRFID(12, rfid);
            string sss = edb.GetDataRFID(13, rfid);
            string _salary = edb.GetDataRFID(9, rfid);
            double rsalary = double.Parse(_salary);
            double d1 = 0, d2 = 0, d3 = 0, d = 0;
            double csalary = 0;
            double bsalary = Double.Parse(edb.GetDataRFID(15, rfid));
            double tax = 0;
            VariablesDB vdb = new VariablesDB();
            //Deduction Rates
            double rate_pagibig = double.Parse(vdb.GetData(2));
            double rate_philhealth = double.Parse(vdb.GetData(3));
            double rate_sss = double.Parse(vdb.GetData(4));

            if (pagibig == "yes")
            {
                d1 = rsalary * rate_pagibig / 2;
                d1 = Math.Round(d1, 2);
                if(d1 > 50)
                {
                    d1 = 50;
                }
            }
            if (philhealth == "yes")
            {
                d2 = rsalary * rate_philhealth / 2;
                d2 = Math.Round(d2, 2);
            }
            if (sss == "yes")
            {
                d3 = rsalary * rate_sss / 2;
                d3 = Math.Round(d3, 2);
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

            csalary = rsalary - d1 - d2 - d3 - tax;
            d = d1 + d2 + d3;

            lblRSalary.Text = rsalary.ToString();
            lblTax.Text = tax.ToString();
            lblDeduction.Text = d.ToString();
            lblSalary.Text = csalary.ToString();

            lblPAGIBIG.Text = d1.ToString();
            lblPhilhealth.Text = d2.ToString();
            lblSSS.Text = d3.ToString();
            lblDeduction2.Text = d.ToString();

        }


    }
}
