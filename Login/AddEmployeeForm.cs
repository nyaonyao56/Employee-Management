using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Login {
    public partial class AddEmployeeForm : Form {
        private EmployeeManagement empManagement;
        private string myConnection;
        private int id;
        private string lastName;
        private string firstName;
        private string jobPos;
        private DateTime startDate;
        private DateTime endDate;

        public AddEmployeeForm(EmployeeManagement empManagement) {
            InitializeComponent();
            this.empManagement = empManagement;
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e) {
            //myConnection = this.empManagement.MyConnection;
        }

        private void submitButton_Click(object sender, EventArgs e) {
            /*
            string[] row = {
                idTextBox.Text, lastNameTextBox.Text, firstNameTextBox.Text, jobTitleTextBox.Text,
                startDateTextBox.Text
            };

            var listViewItem = new ListViewItem(row);
            this.empManagement.employeeListView.Items.Add(listViewItem);
            */
            var myConn = this.empManagement.MyConn;
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] array = ms.GetBuffer();
            //myConn = new OdbcConnection(myConnection);
            OdbcCommand myCommand = new OdbcCommand();
            OdbcTransaction transaction = null;
            myConn.Open();
            transaction = myConn.BeginTransaction();
            myCommand.Connection = myConn;
            myCommand.Transaction = transaction;
            myCommand.CommandText = "INSERT INTO employee(picture, last_name, first_name, job_title, start_date, end_date) VALUES(?,?,?,?,?,?)";
            myCommand.Parameters.Add("picture", OdbcType.VarBinary).Value = array;
            myCommand.Parameters.Add("last_name", OdbcType.VarChar).Value = lastNameTextBox.Text;
            myCommand.Parameters.Add("first_name", OdbcType.VarChar).Value = firstNameTextBox.Text;
            myCommand.Parameters.Add("job_title", OdbcType.VarChar).Value = jobTitleTextBox.Text;
            myCommand.Parameters.Add("start_date", OdbcType.DateTime).Value = startDatePicker.Text;
            myCommand.Parameters.Add("end_date", OdbcType.DateTime).Value = endDatePicker.Text;
            myCommand.ExecuteNonQuery();

            transaction.Commit();
            myConn.Close();
            this.empManagement.retrieveData();
        }

        private void clearButton_Click(object sender, EventArgs e) {
            lastNameTextBox.Clear();
            firstNameTextBox.Clear();
            jobTitleTextBox.Clear();
        }

        private void okButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void uploadButton_Click(object sender, EventArgs e) {
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Jpg Files|*.jpg|Jpeg File|*.jpeg|Png Files|*.png"; 
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                pictureDirTextBox.Text = fileDialog.FileName;
                pictureBox1.ImageLocation = fileDialog.FileName;
            }
        }

        public int Id {
            get { return id; }

            set { id = value; }
        }

        public string LastName {
            get { return lastName; }

            set { lastName = value; }
        }

        public string FirstName {
            get { return firstName; }

            set { firstName = value; }
        }

        public string JobTitle {
            get { return jobPos; }

            set { jobPos = value; }
        }

        public DateTime StartDate {
            get { return startDate; }

            set { startDate = value; }
        }

        public DateTime EndDate {
            get { return endDate; }

            set { endDate = value; }
        }

        public Boolean isEdit() {
            return true;
        }
    }
}
