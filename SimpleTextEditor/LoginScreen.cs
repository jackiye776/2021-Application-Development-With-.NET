using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public partial class LoginScreen : Form
    {
        Users userManager = new Users();

        public LoginScreen()
        {
            InitializeComponent(); 
            userManager.loadUsers(); // load data from "login.txt"
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = inputUsername.Text.TrimStart().TrimEnd(); // trims white spaces of start & end 
            if (inputUsername.Text == string.Empty) // check if username field is empty
            {
                MessageBox.Show("Please Input Username!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (inputPassword.Text == string.Empty) // check if password field is empty
            {
                MessageBox.Show("Please Input Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (userManager.checkLogin(username, inputPassword.Text)) // check login method
            {
                new TextEditorScreen(username).Show(); // if exists, passes username and open TextEditorScreen
                this.Hide(); // hides login screen
            }
            else // display error message
            {
                MessageBox.Show("Credentials Invalid!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        private void newUserButton_Click(object sender, EventArgs e) // when new UserControl button is clicked
        {
            new NewUserScreen().Show(); // opens NewUserScreen
            this.Hide(); // Hides this login screen
        }

        private void exitButton_Click(object sender, EventArgs e) // when exit button is clicked 
        {
            Application.Exit(); // Closes the application
        }

        // If exit button is pressed / suddenly closed event hanlder will properly exit the application
        private void LoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
