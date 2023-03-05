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
    public partial class ManageAdmins : Form
    {
        private bool exit = true;
        bool onAdd = true;
        private string _username = "";

        public ManageAdmins()
        {
            InitializeComponent();
            dataRefresh();
            Clear();
        }

        private void ManageAdmins_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            exit = false;
            FormState.PreviousPage.Show();
            this.Close();
        }

        private void Clear()
        {
            txtUsername.Text = "";
            txtUsername.ReadOnly = false;
            txtFName.Text = "";
            txtLName.Text = "";
            txtPassword.Text = "";
            txtRePassword.Text = "";
            txtUsername.Enabled = false;
            txtFName.Enabled = false;
            txtLName.Enabled = false;
            txtPassword.Enabled = false;
            txtRePassword.Enabled = false;
            btnUndo.Enabled = false;
            btnConfirm.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            onAdd = true;
            txtUsername.Enabled = true;
            txtFName.Enabled = true;
            txtLName.Enabled = true;
            txtPassword.Enabled = true;
            txtRePassword.Enabled = true;
            btnUndo.Enabled = false;
            btnConfirm.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            onAdd = false;
            txtUsername.Enabled = true;
            txtUsername.ReadOnly = true;
            txtFName.Enabled = true;
            txtLName.Enabled = true;
            txtPassword.Enabled = true;
            txtRePassword.Enabled = true;
            btnUndo.Enabled = true;
            btnConfirm.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            try
            {
                _username = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }
            catch (NullReferenceException)
            {
                System.Windows.Forms.MessageBox.Show("Unable to perform edit to any user!", "Database Empty",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            AdminDB adb = new AdminDB();
            txtUsername.Text = _username;
            txtFName.Text = adb.GetData(2, _username);
            txtLName.Text = adb.GetData(3, _username);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (onAdd)
            {
                if(txtPassword.Text == "" && !(txtPassword.Text != txtRePassword.Text))
                {
                    MessageBox.Show("Password empty or do not match", "Check your credentials!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                AdminDB adb = new AdminDB();
                string Enpass = SimpleSecurity.Encrypt(txtPassword.Text);
                adb.AddAdmin(txtUsername.Text, Enpass, txtFName.Text, txtLName.Text);
                Clear();
            }
            else
            {
                if (txtPassword.Text == "" && !(txtPassword.Text != txtRePassword.Text))
                {
                    MessageBox.Show("Password empty or do not match", "Check your credentials!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                AdminDB adb = new AdminDB();
                string Enpass = SimpleSecurity.Encrypt(txtPassword.Text);
                adb.EditAdmin(txtUsername.Text, Enpass, txtFName.Text, txtLName.Text);
                Clear();
            }
            dataRefresh();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            AdminDB adb = new AdminDB();
            txtUsername.Text = _username;
            txtFName.Text = adb.GetData(2, _username);
            txtLName.Text = adb.GetData(3, _username);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _username = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                if(_username == "admin")
                {
                    MessageBox.Show("Master Admin Cannot Be Deleted!");
                    return;
                }
            }
            catch (NullReferenceException)
            {
                System.Windows.Forms.MessageBox.Show("Unable to perform delete to any user!", "Database Empty",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this admin from the" +
                "database?", "Delete Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No)
            {
                return;
            }
            AdminDB adb = new AdminDB();
            adb.DeleteAdmin(_username);

            dataRefresh();
        }

        void dataRefresh()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            AdminDB adb = new AdminDB();
            adb.AdminList(ref dataGridView1);
        }
    }
}
