using System;
using System.Windows.Forms;

/*
 * Author: Stanley Chu A00871993
 * Ver: 1.007
 * Date: January 11th, 2017
 * 
 * Login form which for now, only accepts the user admin and password mesos. Upon successful login set the dialogresult
 * to OK and go to the main form which is the EmployeeManagement form.
*/
namespace Login {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        // Login button click event that authenticates the user and upon successful authentication takes the user to
        // the main form to manage their employees.
        private void loginButton_Click(object sender, EventArgs e) {
            if (usernameTextBox.Text == "admin" && passwordTextBox.Text == "mesos") {
                this.DialogResult = DialogResult.OK;
            }else {
                MessageBox.Show("Please enter a valid username or password.");
            }
        }

        // Exit button click event which just terminates and exits the application.
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
