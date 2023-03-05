using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Employee_Login_System_Using_RFID_Reader
{
    public partial class ExportToExcel : Form
    {
        private bool exit = true;


        public ExportToExcel()
        {
            InitializeComponent();
            dataRefresh();
        }

        private void ExportToExcel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
            }
        }

        private void dataRefresh()
        {
            dgvPayout.Rows.Clear();
            dgvPayout.Refresh();
            PayoutDB pdb = new PayoutDB();
            pdb.PayoutList(ref dgvPayout);
            pdb.PayoutListDeduction1(ref dgvPAGIBIG);
            pdb.PayoutListDeduction2(ref dgvPayoutPhilhealth);
            pdb.PayoutListDeduction3(ref dgvPayoutSSS);
            pdb.PayoutListDeduction4(ref dgvPayoutTax);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            exit = false;
            FormState.PreviousPage.Show();
            this.Close();
        }

        private void copyAlltoClipboard()
        {
            dgvPayout.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvPayout.MultiSelect = true;
            dgvPayout.SelectAll();
            DataObject dataObj = dgvPayout.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void btnExportPAGIBIG_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard1();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void copyAlltoClipboard1()
        {
            dgvPAGIBIG.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvPAGIBIG.MultiSelect = true;
            dgvPAGIBIG.SelectAll();
            DataObject dataObj = dgvPAGIBIG.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
    }
}
