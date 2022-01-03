using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public partial class NewUserScreen : Form
    {
        Users userManager = new Users();
        
        public NewUserScreen()
        {
            InitializeComponent();
            userManager.loadUsers(); // load data from "login.txt"
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            new LoginScreen().Show(); // opens loginscreen
            this.Hide(); // hides this screen
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Check if any fields are empty besides DOB / User Type
            if (inputUsername.Text == string.Empty || inputPassword.Text == string.Empty || inputRePass.Text == string.Empty || inputFName.Text == string.Empty || inputLName.Text == string.Empty)
            { 
                MessageBox.Show("Please Enter All Fields!", "New User Creation Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (inputPassword.Text != inputRePass.Text) // Checks if password ans re-entered password is identical
            {
                MessageBox.Show("Password Is Not Identical!\nPlease Re-Enter Password!", "New User Creation Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (inputType.SelectedItem == null || inputType.SelectedIndex == -1) // Checks if an item is selected in combo box
            {
                MessageBox.Show("Please Select A User-Type!", "New User Creation Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (userManager.checkUserNameExists(inputUsername.Text)) // Checks if username exists in file
            {
                MessageBox.Show("Username Exists!\nPlease Enter Another Username", "New User Creation Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (userManager.addUser(inputUsername.Text.TrimStart().TrimEnd(), inputPassword.Text, inputType.Text, inputFName.Text.TrimStart().TrimEnd(), inputLName.Text.TrimStart().TrimEnd(), inputDOB.Text)) // adds users to file
            {
                MessageBox.Show("Account Succesfully Created!\nReturning Back To Login Screen", "New User Creation Succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new LoginScreen().Show(); // opens loginscreen
                this.Hide(); // hides this screen
            }
            else
            {
                MessageBox.Show("An Error Has Occurred! Please Try Again", "New User Creation Failed!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // If exit button is pressed / suddenly closed event hanlder will properly exit the application
        private void NewUserScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
