using System;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace Employee_Login_System_Using_RFID_Reader
{
    public class AdminDB
    {
        private readonly string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employeeloginsys;Sslmode=none;";
        string query = "SELECT * FROM admin_list";
        string query_add = "INSERT INTO admin_list(`username`, `password`, `fname`, `lname`) VALUES (";
        string query_edit = "UPDATE `admin_list` SET ";
        string query_delete = "DELETE FROM `admin_list` WHERE username = '";
        private MySqlConnection databaseConnection;
        private MySqlCommand commandDatabase;
        private MySqlDataReader reader;

        public AdminDB()
        {

            
        }

        public void AddAdmin(string username, string password, string fname, string lname)
        {
            query_add = query_add + "'" + username + "', '" + password + "', '" + fname + "', '" + lname + "')";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_add, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void EditAdmin(string username, string password, string fname, string lname)
        {
            query_edit = query_edit + "`lname`='" + lname + "',`fname`='" + fname + "',`password`='" + password + "'WHERE username = '" + username + "'";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_edit, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                System.Windows.Forms.MessageBox.Show("Admin's details has been edited. ", "Action successful", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void DeleteAdmin(string username)
        {
            query_delete = query_delete + username + "'";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_delete, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                System.Windows.Forms.MessageBox.Show("Admin Deleted Successfully!", "Action successful",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void AdminList(ref System.Windows.Forms.DataGridView dgvAdmin)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string[] row = {reader.GetString(0), reader.GetString(2), reader.GetString(3)};
                    dgvAdmin.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public (string, string, bool) CheckAcc(string username, string password)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            string fname = "", lname = "";
            bool match = false;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string Depass = SimpleSecurity.Decrypt(reader.GetString(1));
                    if(username == reader.GetString(0) && password == Depass)
                    //if (username == reader.GetString(0) && password == reader.GetString(1))
                    {
                        match = true;
                        fname = reader.GetString(2);
                        lname = reader.GetString(3);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return (fname, lname, match);
        }

        public string GetData(int index, string username)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if (username == reader.GetString(0))
                    {
                        return reader.GetString(index);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return "";
        }
    }

    public class EmployeeDB
    {
        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employeeloginsys;Sslmode=none;";
        string query_get = "SELECT * FROM employee_list";
        string query_add = "INSERT INTO employee_list(`lname`, `fname`, `mi`, `address`, `contactno`, `birthday`, " +
            "`rfid`, `username`, `password`, `salary`, `refdate`, `base_pay`) VALUES (";
        string query_edit = "UPDATE `employee_list` SET ";// `first_name`='Willy',`last_name`='Wonka',`address`='Chocolate factory' WHERE username = 1";
        string query_delete = "DELETE FROM `employee_list` WHERE username = '";
        string query_updateSalary = "UPDATE `employee_list` SET `salary` = ";
        string query_updateRefDate = "UPDATE `employee_list` SET `refdate` = '";
        private MySqlConnection databaseConnection;
        private MySqlCommand commandDatabase;
        private MySqlDataReader reader;

        public EmployeeDB()
        {

        }

        public bool EmployeeAdd(string lname, string fname, string mi, string address, string contactno,
            string birthday, string rfid, string username, string password, string base_pay)
        {
            query_add = query_add + "'" + lname + "', '" + fname + "', '" + mi + "', '" + address + "', '" +
                contactno + "', '" + birthday + "', '" + rfid + "', '" + username + "', '" + password + "', " +
                "0, '" + DateTime.Now.ToString("MMMM dd, yyyy") + "', '" + base_pay + "')";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_add, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return true;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        public void EmployeeEdit(string lname, string fname, string mi, string address, string contactno,
            string birthday, string rfid, string username, string password, string pagibig, string philhealth, string sss, string loan, string base_pay, string cash_adv, string rest_day)
        {
            query_edit = query_edit + "`lname`='" + lname + "',`fname`='" + fname + "',`mi`='" + mi + "'," +
                "`address`='" + address + "',`contactno`='" + contactno + "',`birthday`='" + birthday + "'," +
                "`rfid`='" + rfid + "',`password`='" + password + "',`pagibig`='" + pagibig + "',`philhealth`='" + philhealth
                + "',`sss`='" + sss + "',`loan`='" + loan + "',`base_pay`='" + base_pay + "',`cash_adv`='" + cash_adv + "',`rest_day`='" + rest_day + "'WHERE username = '" + username + "'";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_edit, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                System.Windows.Forms.MessageBox.Show("Employee's details has been edited. ", "Action successful", System.Windows.Forms.MessageBoxButtons.OK, 
                    System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void EmployeeDelete(string username)
        {
            query_delete = query_delete + username + "'";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_delete, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                System.Windows.Forms.MessageBox.Show("Employee Deleted Successfully!", "Action successful",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public (string, bool) CheckAcc(string username, string password)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            string fname = "";
            bool match = false;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string Depass = SimpleSecurity.Decrypt(reader.GetString(8));
                    if (username == reader.GetString(7) && password == Depass)
                    {
                        match = true;
                        fname = reader.GetString(2);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return (fname, match);
        }

        public bool RFIDCheck(string rfid)
        {
            bool checkRFID = false;
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(6) == rfid)
                    {
                        checkRFID =  true;
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return checkRFID;
        }

        public string GetData(int index, string username)
        {
            string data = "";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if (username == reader.GetString(7))
                    {
                        data = reader.GetString(index);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return data;
        }

        public string GetDataRFID(int index, string rfid)
        {
            string data = "";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if (rfid == reader.GetString(6))
                    {
                        data = reader.GetString(index);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return data;
        }

        public bool UpdateSalary(string rfid, double addSalary)
        {
            string current = GetDataRFID(9, rfid);
            double currentSalary = 0;
            if(current != "")
            {
                if (!double.TryParse(current, out currentSalary))
                {
                    return false;
                }
            }
            double salary = currentSalary + addSalary;
            query_updateSalary = query_updateSalary + salary.ToString() + " WHERE rfid = " + rfid;

            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_updateSalary, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                return true;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        public void ResetSalary(string rfid)
        {
            query_updateSalary = query_updateSalary + "0" + " WHERE rfid = " + rfid;

            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_updateSalary, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void UpdateRefDate(string rfid, string date)
        {
            
            query_updateRefDate = query_updateRefDate + date + "' WHERE rfid = '" + rfid + "'";

            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_updateRefDate, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void EmployeeList(ref System.Windows.Forms.DataGridView dgvEmployeeList)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)};
                    dgvEmployeeList.Rows.Add(row);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured", 
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void EmployeeListPayout(ref System.Windows.Forms.DataGridView dgvEmployeeList)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(6),
                    reader.GetString(10), reader.GetString(9)};
                    dgvEmployeeList.Rows.Add(row);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void EmployeeListSpecific(ref System.Windows.Forms.DataGridView dgvEmployeeList, string filter, int index){
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if(reader.GetString(index) == filter)
                    {
                        string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)};
                        dgvEmployeeList.Rows.Add(row);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void EmployeeListSalary(ref System.Windows.Forms.DataGridView dgvEmployeeList)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2),
                    reader.GetString(6), reader.GetString(7), reader.GetString(9)};
                    dgvEmployeeList.Rows.Add(row);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void EmployeeListSalarySpecific(ref System.Windows.Forms.DataGridView dgvEmployeeList, string filter, int index)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(index) == filter)
                    {
                        string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetString(6), reader.GetString(7), reader.GetString(9)};
                        dgvEmployeeList.Rows.Add(row);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }

    public class AttendanceDB
    {
        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employeeloginsys;Sslmode=none;";
        string query_get = "SELECT * FROM attendance_record";
        string query_time_in = "INSERT INTO attendance_record(`no`, `lname`, `fname`, `mi`, `date`, `time_in`, `time_out`, `rfid`, " +
            "`salary_earned`) VALUES (NULL, ";
        string query_time_out = "UPDATE `attendance_record` SET ";
        string query_leave = "INSERT INTO attendance_record(`no`, `lname`, `fname`, `mi`, `date`, `time_in`, `time_out`, `rfid`, " +
            "`salary_earned`) VALUES (NULL, ";
        private MySqlConnection databaseConnection;
        private MySqlCommand commandDatabase;
        private MySqlDataReader reader;

        public AttendanceDB()
        {

        }

        public void TimeIn(string lname, string fname, string mi, string date, string time_in, string rfid)
        {
            bool found = isTimeIn(date, rfid);

            if (found)
            {
                System.Windows.Forms.MessageBox.Show("You have already timed in today. Switch the button to " +
                    "change to time out.", "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            query_time_in = query_time_in + "'" + lname + "', '" + fname + "', '" + mi + "', '" + date + "', '" +
                time_in + "', '' ,'" + rfid + "', '" + "0')";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_time_in, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public bool isTimeIn(string date, string rfid)
        {
            bool found = false;
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if (date == reader.GetString(4) && rfid == reader.GetString(7) && reader.GetString(5) != "")
                    {
                        found = true;
                    }
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return found;
        }

        public void TimeOut(string date, string rfid, string time_out, string rest_day)
        {
            string no = "";
            string time_in = "";
            bool found = false;
            bool notIn = false;

            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if (date == reader.GetString(4) && rfid == reader.GetString(7))
                    {
                        no = reader.GetString(0);
                        time_in = reader.GetString(5);
                        found = true;
                        if (reader.GetString(6) == "")
                        {
                            notIn = true;
                        }
                    }
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            if (!notIn)
            {
                System.Windows.Forms.MessageBox.Show("You have already timed out today or not timed in yet.",
                    "Time Out Record Exists or Time In Record Doesn't Exist ", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            if (!found && notIn)
            {
                System.Windows.Forms.MessageBox.Show("No records of time in has been found! Please time in first.",
                    "No Time In Record", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }

            bool holiday = false;
            string htype = "";
            bool Isrest_day = false;
            HolidayDB hdb = new HolidayDB();
            holiday = hdb.IsHoliday(date);
            if (holiday)
            {
                htype = hdb.HolidayType(date);
            }
            EmployeeDB edb = new EmployeeDB();
            double bsalary = double.Parse(edb.GetDataRFID(15, rfid));
            string erest_day = edb.GetDataRFID(17, rfid);
            if(erest_day == rest_day)
            {
                Isrest_day = true;
            }
            string salary_earned = CalculateSalary(time_in, time_out, holiday, bsalary, htype, Isrest_day);
            query_time_out = query_time_out + "`time_out`='" + time_out + "',`salary_earned`='" + salary_earned 
                + "'WHERE no = '" + no + "'";

            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_time_out, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            double salary = double.Parse(salary_earned);
            edb.UpdateSalary(rfid, salary);
        }

        public bool isTimeOut(string date, string rfid)
        {
            bool found = false;
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if (date == reader.GetString(4) && rfid == reader.GetString(7) && reader.GetString(6) != "")
                    {
                        found = true;
                    }
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return found;
        }

        /*
        public bool isTimeOutPrev(string date, string rfid)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if (date == reader.GetString(4) && rfid == reader.GetString(8))
                    {
                        return true;
                    }
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return false;
        }
        */

        private bool CheckIn(string date, string rfid)
        {
            string no = "";
            string time_in = "";

            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if (date == reader.GetString(4) && rfid == reader.GetString(7))
                    {
                        no = reader.GetString(0);
                        time_in = reader.GetString(5);
                        return true;
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return false;
        }

        public void SetLeave(bool leave_type, string rfid, string lname, string fname, string mi, string date, string base_pay)
        {
            if (!leave_type)
            {
                query_leave = query_time_in = query_time_in + "'" + lname + "', '" + fname + "', '" + mi + "', '" + date + "', '" +
                "SL" + "', 'SL' ,'" + rfid + "', '" + base_pay + "')";
            }
            else
            {
                query_leave = query_time_in = query_time_in + "'" + lname + "', '" + fname + "', '" + mi + "', '" + date + "', '" +
                "VL" + "', 'VL' ,'" + rfid + "', '" + base_pay + "')";
            }
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_leave, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            EmployeeDB edb = new EmployeeDB();
            double salary = double.Parse(base_pay);
            edb.UpdateSalary(rfid, salary);
           
        }

        private string CalculateSalary(string time_in, string time_out, bool holiday, double bsalary, string htype, bool Isrest_day)
        {
            //bool sholiday = false;
            string[] t1 = time_in.Split(':');
            string[] t2 = time_out.Split(':');
            int h1 = int.Parse(t1[0]);
            int h2 = int.Parse(t2[0]);
            int m1 = int.Parse(t1[1]);
            int m2 = int.Parse(t2[1]);
            double ot_salary = 0;
            int ot_hours = 0;
            int ot_minutes = 0;
            bsalary = bsalary / 8;
            double salary = 0;
            int nd_hours = 0;
            double nd_salary = 0;


            int minutes = 60 * (h2 - h1 - 1) + (m2 - m1);
            int hours = minutes / 60;

            if(h2 < 18 && h1 < 18)
            {
                salary = hours * bsalary;
            }
            else if(h2 >= 18)
            {
                minutes = 60 * (17 - h1 - 1) - m1;
                hours = minutes / 60;
                //salary = hours * bsalary;
                ot_minutes = 60 * (h2 - 17) + m2;
                ot_hours = ot_minutes / 60;
                //ot_salary = ot_hours * bsalary;
                int x = 0;
                if(hours < 8)
                {
                    x = 8 - hours;
                    ot_hours = ot_hours - x;
                    if (ot_hours < 0)
                    {
                        ot_hours = 0;
                        hours = ot_hours + hours;
                    }
                    else
                    {
                        hours = 8;
                        ot_hours = ot_hours - x;
                    }
                }
                salary = hours * bsalary;
                ot_salary = ot_hours * bsalary;
            }
            else if(h1 >= 17)
            {
                minutes = 60 * (24 - h1 + h2) + (m2 - m1);
                hours = minutes / 60;
                if(hours > 8)
                {
                    nd_hours = 8;
                }
                else
                {
                    nd_hours = hours;
                }
                salary = hours * bsalary;
                nd_salary = nd_hours * bsalary;
            }

            if(holiday)
            {
                if(htype == "Regular" && Isrest_day)
                {
                    salary = salary * 2.6;
                    ot_salary = ot_salary * 3.38;
                    nd_salary = nd_salary * 2.6 * 0.10;
                }
                else if(htype == "Regular" && !Isrest_day)
                {
                    salary = salary * 2;
                    ot_salary = ot_salary * 2.6;
                    nd_salary = nd_salary * 2 * 0.10;
                }
                else if(htype == "Special" && Isrest_day){
                    salary = salary * 1.5;
                    ot_salary = ot_salary * 1.95;
                    nd_salary = nd_salary * 1.5 * 0.10;
                }
                else if(htype == "Special" || Isrest_day)
                {
                    salary = salary * 1.3;
                    ot_salary = ot_salary * 1.69;
                    nd_salary = nd_salary * 1.3 * 0.10;
                }
                else if(htype == "Double" && !Isrest_day)
                {
                    salary = salary * 3;
                    ot_salary = ot_salary * 3.9;
                    nd_salary = nd_salary * 3.3 * 0.10;
                }
                else if (htype == "Double" && Isrest_day)
                {
                    salary = salary * 3;
                    ot_salary = ot_salary * 5.07;
                    nd_salary = nd_salary *3.9 * 0.10;
                }
            }
            else
            {
                if (Isrest_day)
                {
                    salary = salary * 1.3;
                    ot_salary = ot_salary * 1.69;
                    nd_salary = nd_salary * 1.3 * 0.10;
                }
                else
                {
                    ot_salary = ot_salary * 1.25;
                    nd_salary = nd_salary * 0.10;
                }
            }
            salary = salary + ot_salary + nd_salary;
            salary = Math.Round(salary, 2);
            return salary.ToString();
        }

        public void RecordList(ref System.Windows.Forms.DataGridView dgvAttendanceRecord)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(7), reader.GetString(5), reader.GetString(6), reader.GetString(8)};
                    dgvAttendanceRecord.Rows.Add(row);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void RecordListSpecific(ref System.Windows.Forms.DataGridView dgvAttendanceRecord, string date)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if(reader.GetString(4) == date)
                    {
                        string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(7), reader.GetString(5), reader.GetString(6), reader.GetString(8)};
                        dgvAttendanceRecord.Rows.Add(row);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void RecordListSpecific2(ref System.Windows.Forms.DataGridView dgvAttendanceRecord, string date)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(4) == date)
                    {
                        string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(5), reader.GetString(6)};
                        dgvAttendanceRecord.Rows.Add(row);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void RecordListSolo(ref System.Windows.Forms.DataGridView dgvAttendanceRecord, string username)
        {
            EmployeeDB edb = new EmployeeDB();
            string rfid = edb.GetData(6, username);
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if(rfid == reader.GetString(7))
                    {
                        string[] row = {reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(8)};
                        dgvAttendanceRecord.Rows.Add(row);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void RecordListSoloSpecific(ref System.Windows.Forms.DataGridView dgvAttendanceRecord, string username, string date)
        {
            EmployeeDB edb = new EmployeeDB();
            string rfid = edb.GetData(6, username);
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if (rfid == reader.GetString(7) && reader.GetString(4) == date)
                    {
                        string[] row = { reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(8) };
                        dgvAttendanceRecord.Rows.Add(row);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public string FindLatestDate(string refdate, string rfid)
        {
            DateTime first = Convert.ToDateTime(reader);
            DateTime last;
            string latest = "";
            int res;
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if(rfid == reader.GetString(7))
                    {
                        last = Convert.ToDateTime(reader.GetString(4));
                        res = DateTime.Compare(first, last);
                        if(res < 0)
                        {
                            latest = reader.GetString(4);
                        }
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return latest;
        }
    }

    public class PayoutDB
    {
        private readonly string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employeeloginsys;Sslmode=none;";
        string query = "SELECT * FROM payout_record";
        string query_add = "INSERT INTO payout_record(`no`, `lname`, `fname`, `mi`, `username`, " +
            "`rfid`, `from`, `to`, `salary_earned`, `deduction`, `payout`," +
            "`pagibig`, `philhealth`, `sss`, `pagibig_loan`, `sss_loan`, `other_loan`," +
            "`tax`, `cash_adv`, `incentive`) VALUES (NULL, ";
        private MySqlConnection databaseConnection;
        private MySqlCommand commandDatabase;
        private MySqlDataReader reader;

        public PayoutDB()
        {

        }

        public void AddPayout(string lname, string fname, string mi, string username, string rfid, string from, string to, 
            string salary_earned, string deduction, string payout, string pagibig, string philhealth, string sss,
            string pagibig_loan, string sss_loan, string other_loan, string tax, string cash_adv,
            string incentive) {
            query_add = query_add + "'" + lname + "', '" + fname + "', '" + mi + "', '" + username + "', '" +
                rfid + "', '" + from + "', '" + to + "', '" + salary_earned + "', '" + deduction + "', '" + payout + 
                "', '" + pagibig + "', '" + philhealth + "', '" + sss + "', '" + pagibig_loan + "', '" + sss_loan +
                "', '" + other_loan + "', '" + tax + "', '" + cash_adv + "', '" + incentive + "')";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_add, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

        }

        public void PayoutList(ref System.Windows.Forms.DataGridView dgvPayout)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetString(6), reader.GetString(7), reader.GetString(8),
                        reader.GetString(9), reader.GetString(10)};
                    dgvPayout.Rows.Add(row);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void PayoutListSolo(ref System.Windows.Forms.DataGridView dgvPayout, string username)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if(username == reader.GetString(4))
                    {
                        string[] row = {reader.GetString(6), reader.GetString(7), reader.GetString(8),
                            reader.GetString(9), reader.GetString(10)};
                        dgvPayout.Rows.Add(row);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void PayoutListDeduction1(ref System.Windows.Forms.DataGridView dgvPayout)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeDB edb = new EmployeeDB();
                    string pagibig = "0";
                    string ispagibig = edb.GetData(11, reader.GetString(4));
                    if (ispagibig == "yes")
                    {
                        pagibig = reader.GetString(11);
                    }
                    string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetString(6), reader.GetString(7), pagibig };
                    dgvPayout.Rows.Add(row);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void PayoutListDeduction2(ref System.Windows.Forms.DataGridView dgvPayout)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string philhealth = "0";
                    EmployeeDB edb = new EmployeeDB();
                    string isphilhealth = edb.GetData(12, reader.GetString(4));
                    if (isphilhealth == "yes")
                    {
                        philhealth = reader.GetString(12);
                    }
                    string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetString(6), reader.GetString(7), philhealth };
                    dgvPayout.Rows.Add(row);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void PayoutListDeduction3(ref System.Windows.Forms.DataGridView dgvPayout)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string sss = "0";
                    EmployeeDB edb = new EmployeeDB();
                    string issss = edb.GetData(13, reader.GetString(4));
                    if (issss == "yes")
                    {
                        sss = reader.GetString(13);
                    }
                    string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetString(6), reader.GetString(7), sss};
                    dgvPayout.Rows.Add(row);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void PayoutListDeduction4(ref System.Windows.Forms.DataGridView dgvPayout)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    
                    EmployeeDB edb = new EmployeeDB();
                    double tax = 0;
                    double bsalary = Double.Parse(edb.GetData(15, reader.GetString(4)));
                    double salary = Double.Parse(edb.GetData(9, reader.GetString(4)));
                    if (bsalary <= 685)
                    {
                        tax = 0;
                    }
                    else if(bsalary > 685 && bsalary <= 1095)
                    {
                        tax = 0.2 * (salary - 685); // 0 + 20% over 685
                    }
                    else if(bsalary > 1095 && bsalary <= 2191)
                    {
                        tax = 82.19 + 0.25 * (salary - 1096);
                    }
                    else if(bsalary > 2191 && bsalary <= 5478)
                    {
                        tax = 356.16 + 0.3 * (salary - 2192);
                    }
                    else if(bsalary > 5478 && bsalary < 21917)
                    {
                        tax = 1342.47 + 0.32 * (salary - 5479);
                    }
                    else
                    {
                        tax = 6602.74 + 0.35 * (salary - 21918);
                    }

                    string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetString(6), reader.GetString(7), tax.ToString() };
                    dgvPayout.Rows.Add(row);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }

    public class HolidayDB
    {
        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employeeloginsys;Sslmode=none;";
        string query_get = "SELECT * FROM holiday_list";
        string query_add = "INSERT INTO holiday_list(`date`, `type`) VALUES (";
        string query_delete = "DELETE FROM `holiday_list` WHERE no = '";

        private MySqlConnection databaseConnection;
        private MySqlCommand commandDatabase;
        private MySqlDataReader reader;

        public void AddHoliday(string date, string type)
        {
            query_add = query_add + "'" + date +  "', '" + type + "')";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_add, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void DeleteHoliday(string no)
        {
            query_delete = query_delete + no + "'";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_delete, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                System.Windows.Forms.MessageBox.Show("Holiday Removed Successfully!", "Action successful",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void HolidayList(ref System.Windows.Forms.DataGridView dgvHoliday)
        {
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2) };
                    dgvHoliday.Rows.Add(row);
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void HolidayMark(ref System.Windows.Forms.ListBox lbxHoliday)
        {
            //DateTime[] dt;
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    lbxHoliday.Items.Add(reader.GetString(1));
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            
        }

        public bool IsHoliday(string date)
        {
            bool checkHoliday = false;
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if(date == reader.GetString(1))
                    {
                        checkHoliday = true;
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return checkHoliday;
        }

        public string HolidayType(string date)
        {
            string data = "";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_get, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if (date == reader.GetString(1))
                    {
                        data = reader.GetString(2);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return data;
        }
    }

    public class VariablesDB
    {
        private readonly string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=employeeloginsys;Sslmode=none;";
        string query = "SELECT * FROM variables";
        string query_edit = "UPDATE `variables` SET ";
        private MySqlConnection databaseConnection;
        private MySqlCommand commandDatabase;
        private MySqlDataReader reader;

        public VariablesDB()
        {

        }

        public void EditVariables(string other_loan, string pagibig, string philhealth, string sss,
            string t1, string t2, string t3, string t4, string t5, 
            string r1, string r2, string r3, string r4, string r5,
            string c1, string c2, string c3, string c4, string c5)
        {
            query_edit = query_edit + "`other_loan`='" + other_loan + "',`pagibig`='" + pagibig + "',`philhealth`='" + philhealth +
               "',`sss`='" +  sss + "',`t1`='" + t1 + "',`t2`='" + t2 + "',`t3`='" + t3 + "',`t4`='" + t4 + "',`t5`='" + t5 +
               "',`r1`='" + r1 + "',`r2`='" + r2 + "',`r3`='" + r3 + "',`r4`='" + r4 + "',`r5`='" + r5 +
               "',`c1`='" + c1 + "',`c2`='" + c2 + "',`c3`='" + c3 + "',`c4`='" + c4 + "',`c5`='" + c5 + "'WHERE no = '1'";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query_edit, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                System.Windows.Forms.MessageBox.Show("Variables has been edited. ", "Action successful", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public string GetData(int index)
        {
            string data = "";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 120;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(0) == "1")
                    {
                        data =  reader.GetString(index);
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "An error has occured",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return data;
        }

    }
}
