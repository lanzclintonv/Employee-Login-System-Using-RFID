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
    public partial class HolidayControl : Form
    {
        public HolidayControl()
        {
            InitializeComponent();
            DataRefresh();
            //this.monthCalendar1.BoldedDates = new System.DateTime[] { new System.DateTime(2019, 7, 15, 0, 0, 0, 0) };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string htype = "";
            if(rbRegular.Checked == true)
            {
                htype = "Regular";
            }
            else if(rbSpecial.Checked == true)
            {
                htype = "Special";
            }
            else if(rbDouble.Checked == true)
            {
                htype = "Double";
            }
            HolidayDB hdb = new HolidayDB();
            hdb.AddHoliday(dtpHoliday.Value.ToString("MMMM dd, yyyy"), htype);
            MessageBox.Show("Holiday Added Succesfully!");
            DataRefresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string no;
            try
            {
                no = dgvHoliday.Rows[dgvHoliday.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }
            catch (NullReferenceException)
            {
                System.Windows.Forms.MessageBox.Show("Unable to remove any holiday!", "Database Empty",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            HolidayDB hdb = new HolidayDB();
            hdb.DeleteHoliday(no);
            DataRefresh();
        }
        
        private void DataRefresh()
        {
            dgvHoliday.Rows.Clear();
            dgvHoliday.Refresh();
            HolidayDB hdb = new HolidayDB();
            hdb.HolidayList(ref dgvHoliday);
        }
    }
}
