using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Login_System_Using_RFID_Reader
{
    public partial class Variables : Form
    {
        private bool exit = true;

        public Variables()
        {
            InitializeComponent();
            ShowData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            exit = false;
            FormState.PreviousPage.Show();
            this.Close();
        }

        private void Variables_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
            }
        }

        private void ShowData()
        {
            VariablesDB vdb = new VariablesDB();

            txtLoan.Text =  vdb.GetData(1);

            txtPagibig.Text = vdb.GetData(2);
            txtPhilhealth.Text = vdb.GetData(3);
            txtSSS.Text = vdb.GetData(4);

            txtT1.Text = vdb.GetData(5);
            txtT2.Text = vdb.GetData(6);
            txtT3.Text = vdb.GetData(7);
            txtT4.Text = vdb.GetData(8);
            txtT5.Text = vdb.GetData(9);

            txtR1.Text = vdb.GetData(10);
            txtR2.Text = vdb.GetData(11);
            txtR3.Text = vdb.GetData(12);
            txtR4.Text = vdb.GetData(13);
            txtR5.Text = vdb.GetData(14);

            txtC1.Text = vdb.GetData(15);
            txtC2.Text = vdb.GetData(16);
            txtC3.Text = vdb.GetData(17);
            txtC4.Text = vdb.GetData(18);
            txtC5.Text = vdb.GetData(19);
        }

        private void checkHint_CheckedChanged(object sender, EventArgs e)
        {
            if(checkHint.Checked == true)
            {
                lblInfo.Visible = true;
            }
            else
            {
                lblInfo.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool NumbersOnly = true;
            double num;

            //Number Check For Deductions
            #region
            if (!Double.TryParse(txtPagibig.Text, out num))
            {
                NumbersOnly = false;
            }
            if (!Double.TryParse(txtPhilhealth.Text, out num))
            {
                NumbersOnly = false;
            }
            if (!Double.TryParse(txtSSS.Text, out num))
            {
                NumbersOnly = false;
            }
            #endregion

            //Number Check For Range
            #region
            if (!Double.TryParse(txtT1.Text, out num))
            {
                NumbersOnly = false;
            }
            if (!Double.TryParse(txtT2.Text, out num))
            {
                NumbersOnly = false;
            }
            if (!Double.TryParse(txtT3.Text, out num))
            {
                NumbersOnly = false;
            }
            if (!Double.TryParse(txtT4.Text, out num))
            {
                NumbersOnly = false;
            }
            if (!Double.TryParse(txtT5.Text, out num))
            {
                NumbersOnly = false;
            }
            #endregion

            //Number Check For Rates
            #region
            if (!Double.TryParse(txtR1.Text, out num))
            {
                NumbersOnly = false;
            }
            if (!Double.TryParse(txtR2.Text, out num))
            {
                NumbersOnly = false;
            }
            if (!Double.TryParse(txtR3.Text, out num))
            {
                NumbersOnly = false;
            }
            if (!Double.TryParse(txtR4.Text, out num))
            {
                NumbersOnly = false;
            }
            if (!Double.TryParse(txtR5.Text, out num))
            {
                NumbersOnly = false;
            }
            #endregion

            //Number Check for Constants
            #region
            if (!Double.TryParse(txtC1.Text, out num))
            {
                NumbersOnly = false;
            }
            if (!Double.TryParse(txtC2.Text, out num))
            {
                NumbersOnly = false;
            }
            if (!Double.TryParse(txtC3.Text, out num))
            {
                NumbersOnly = false;
            }
            if (!Double.TryParse(txtC4.Text, out num))
            {
                NumbersOnly = false;
            }
            if (!Double.TryParse(txtC5.Text, out num))
            {
                NumbersOnly = false;
            }
            #endregion

            if (NumbersOnly)
            {
                VariablesDB vdb = new VariablesDB();
                vdb.EditVariables(txtLoan.Text, txtPagibig.Text, txtPhilhealth.Text, txtSSS.Text,
                    txtT1.Text, txtT2.Text, txtT3.Text, txtT4.Text, txtT5.Text,
                    txtR1.Text, txtR2.Text, txtR3.Text, txtR4.Text, txtR5.Text,
                    txtC1.Text, txtC2.Text, txtC3.Text, txtC4.Text, txtC5.Text);
                ShowData();
            }
            else
            {
                MessageBox.Show("Please use numbers only except on Loan Name!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        //private bool CheckNumbers()
        //{
            
        //}
    }
}
