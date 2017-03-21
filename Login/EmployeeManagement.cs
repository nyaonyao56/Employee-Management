using System;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

/*
 * Author: Stanley Chu A00871993
 * Ver: 1.007
 * Date: January 11th, 2017
 * 
 * Main form which upon loading will show the login dialog first and upon successful login will dispose of the login
 * dialog and show the main EmployeeManagement form instead.
 * 
 * This form allows admins to manage their employees(add an employee, edit an employees information, and delete and employee)
*/
namespace Login {
    public partial class EmployeeManagement : Form {

        public static string MyConnection = "DSN=myAccess2";
        public OdbcConnection MyConn = new OdbcConnection(MyConnection);
        OdbcCommand myCommand;
        OdbcDataAdapter adapter;
        public EmployeeManagement() {
            InitializeComponent();
        }

        // Load function which takes the user to the login form first which upon successful login will dispose the login
        // dialog and show the main EmployeeManagement form.
        private void EmployeeManagementForm_Load(object sender, EventArgs e) {
            deleteButton.Enabled = false;
            editButton.Enabled = false;
            var login = new Login();
            login.ShowDialog();
            
            if (login.DialogResult != DialogResult.OK) {
                Application.Exit();
            }
            
            this.Show();
            login.Dispose();
            retrieveData();

        }

        private void populate(string id, string lastName, string firstName, string jobTitle, string startDate, string endDate) {
            string[] row = { id, lastName, firstName, jobTitle, startDate, endDate };
            var item = new ListViewItem(row);
            employeeListView.Items.Add(item);
        }

        public void retrieveData() {
            employeeListView.Items.Clear();
            var query = "SELECT * FROM employee";
            myCommand = new OdbcCommand(query, MyConn);
            MyConn.Open();
            adapter = new OdbcDataAdapter(myCommand);
            var table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows) {
                populate(row[0].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
            }

            MyConn.Close();
            table.Rows.Clear();
        }

        private void editData(int id) {
            var query = "UPDATE employee SET last_name = ?,  first_name = ?, job_title = ?, start_date = ?, end_date = ? WHERE ID = ?";

            myCommand = new OdbcCommand();
            OdbcTransaction transaction = null;
            MyConn.Open();
            transaction = MyConn.BeginTransaction();
            myCommand.Connection = MyConn;
            myCommand.Transaction = transaction;
            myCommand.CommandText = query;
            myCommand.Parameters.Add("last_name", OdbcType.VarChar).Value = lastNameTextBox.Text;
            myCommand.Parameters.Add("first_name", OdbcType.VarChar).Value = firstNameTextBox.Text;
            myCommand.Parameters.Add("job_title", OdbcType.VarChar).Value = jobTextBox.Text;
            myCommand.Parameters.Add("start_date", OdbcType.DateTime).Value = startDatePicker.Text;
            myCommand.Parameters.Add("end_date", OdbcType.DateTime).Value = endDatePicker.Text;
            myCommand.Parameters.Add("ID", OdbcType.Int).Value = id;
            myCommand.ExecuteNonQuery();

            transaction.Commit();
            MyConn.Close();
            retrieveData();
    }

        private void deleteData(int id) {
            var query = "DELETE FROM employee WHERE ID= ?";

            myCommand = new OdbcCommand(query, MyConn);
            OdbcTransaction transaction = null;
            MyConn.Open();
            transaction = MyConn.BeginTransaction();
            myCommand.Connection = MyConn;
            myCommand.Transaction = transaction;
            myCommand.CommandText = query;
            myCommand.Parameters.Add("ID", OdbcType.Int).Value = id;
            myCommand.ExecuteNonQuery();

            transaction.Commit();
            MyConn.Close();
            retrieveData();
        }

        // Add button click event which allows users to add an employee.
        private void addButton_Click(object sender, EventArgs e) {
            var addEmpForm = new AddEmployeeForm(this);
            addEmpForm.ShowDialog();
        }

        // Listview mouse click event which allows users to select a row in the listview to display information on the text boxes.
        private void employeeListView_MouseClick(object sender, MouseEventArgs e) {
            if (employeeListView.SelectedItems.Count > 0) {
                var query = "SELECT picture FROM employee WHERE ID= ?";

                var selectedRow = employeeListView.SelectedItems[0].SubItems[0].Text;
                var id = Convert.ToInt32(selectedRow);
                myCommand = new OdbcCommand(query, MyConn);
                OdbcTransaction transaction = null;
                MyConn.Open();
                transaction = MyConn.BeginTransaction();
                myCommand.Connection = MyConn;
                myCommand.Transaction = transaction;
                myCommand.CommandText = query;
                myCommand.Parameters.Add("ID", OdbcType.Int).Value = id;
                myCommand.ExecuteNonQuery();
                transaction.Commit();

                var table = new DataTable();
                adapter = new OdbcDataAdapter(myCommand);
                adapter.Fill(table);

                if (table.Rows[0]["picture"] != DBNull.Value)
                {
                    byte[] array = (byte[])table.Rows[0]["picture"];
                    Image img = (Image)(new ImageConverter()).ConvertFrom(array);
                    empPictureBox.Image = img;
                }
                else
                {
                    empPictureBox.Image = null;
                }

                MyConn.Close();

                var item = employeeListView.SelectedItems[0];
                idTextBox.Text = item.SubItems[0].Text;
                lastNameTextBox.Text = item.SubItems[1].Text;
                firstNameTextBox.Text = item.SubItems[2].Text;
                jobTextBox.Text = item.SubItems[3].Text;
                startDatePicker.Text = item.SubItems[4].Text;
                endDatePicker.Text = item.SubItems[5].Text;
                editButton.Enabled = false;
                deleteButton.Enabled = (employeeListView.Items.Count > 0);
            } else {
                idTextBox.Text = string.Empty;
                lastNameTextBox.Text = string.Empty;
                firstNameTextBox.Text = string.Empty;
                jobTextBox.Text = string.Empty;
                startDatePicker.Text = string.Empty;
                endDatePicker.Text = string.Empty;
            }
        }

        // Edit button click event which allows users to edit an employees information. Textboxes cannot be empty
        // in order for users to edit, else an error message will show.
        private void editButton_Click(object sender, EventArgs e) {
            /*
            if (string.IsNullOrEmpty(idTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) ||
                string.IsNullOrEmpty(firstNameTextBox.Text)
                || string.IsNullOrEmpty(jobTextBox.Text) || string.IsNullOrEmpty(startDateTextBox.Text)) {
                MessageBox.Show("Textbox cannot be empty");
            }else {
                employeeListView.SelectedItems[0].SubItems[0].Text = idTextBox.Text;
                employeeListView.SelectedItems[0].SubItems[1].Text = lastNameTextBox.Text;
                employeeListView.SelectedItems[0].SubItems[2].Text = firstNameTextBox.Text;
                employeeListView.SelectedItems[0].SubItems[3].Text = jobTextBox.Text;
                employeeListView.SelectedItems[0].SubItems[4].Text = startDateTextBox.Text;
                employeeListView.SelectedItems[0].SubItems[5].Text = endDateTextBox.Text;
            }
            */

            var selectedRow = employeeListView.SelectedItems[0].SubItems[0].Text;
            var id = Convert.ToInt32(selectedRow);
            editData(id);
        }

        // Delete button click event which allows users to delete an employee.
        private void deleteButton_Click(object sender, EventArgs e) {
            /*
            employeeListView.Items.Remove(employeeListView.SelectedItems[0]);
            idTextBox.Clear();
            lastNameTextBox.Clear();
            firstNameTextBox.Clear();
            jobTextBox.Clear();
            startDateTextBox.Clear();
            deleteButton.Enabled = (employeeListView.Items.Count > 0);
            editButton.Enabled = (employeeListView.Items.Count > 0);
            */

            String selectedRow = employeeListView.SelectedItems[0].SubItems[0].Text;
            int id = Convert.ToInt32(selectedRow);
            deleteData(id);
        }

        // Textbox change events which will enable the edit button once it detects a change in the text box
        // either programmatically or from user interaction.
        private void idTextBox_TextChanged(object sender, EventArgs e) {
            editButton.Enabled = true;
        }

        // Textbox change events which will enable the edit button once it detects a change in the text box
        // either programmatically or from user interaction.
        private void lastNameTextBox_TextChanged(object sender, EventArgs e) {
            editButton.Enabled = true;
        }

        // Textbox change events which will enable the edit button once it detects a change in the text box
        // either programmatically or from user interaction.
        private void firstNameTextBox_TextChanged(object sender, EventArgs e) {
            editButton.Enabled = true;
        }

        // Textbox change events which will enable the edit button once it detects a change in the text box
        // either programmatically or from user interaction.
        private void jobTextBox_TextChanged(object sender, EventArgs e) {
            editButton.Enabled = true;
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e) {
            editButton.Enabled = true;
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e) {
            editButton.Enabled = true;
        }
    }
}
