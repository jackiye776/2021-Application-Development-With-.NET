
namespace SimpleTextEditor
{
    partial class NewUserScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.inputRePass = new System.Windows.Forms.TextBox();
            this.reEnterPassword = new System.Windows.Forms.Label();
            this.inputFName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.inputLName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputDOB = new System.Windows.Forms.DateTimePicker();
            this.userType = new System.Windows.Forms.Label();
            this.inputType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(187, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "New User Creation";
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(344, 520);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(109, 42);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.AutoSize = true;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitButton.Location = new System.Drawing.Point(187, 520);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(109, 42);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // inputPassword
            // 
            this.inputPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputPassword.Location = new System.Drawing.Point(371, 174);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(230, 34);
            this.inputPassword.TabIndex = 11;
            this.inputPassword.UseSystemPasswordChar = true;
            // 
            // inputUsername
            // 
            this.inputUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputUsername.Location = new System.Drawing.Point(371, 119);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(230, 34);
            this.inputUsername.TabIndex = 10;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.SystemColors.Control;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(65, 174);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(139, 37);
            this.Password.TabIndex = 9;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.SystemColors.Control;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(65, 119);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(146, 37);
            this.Username.TabIndex = 8;
            this.Username.Text = "Username";
            // 
            // inputRePass
            // 
            this.inputRePass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputRePass.Location = new System.Drawing.Point(371, 236);
            this.inputRePass.Name = "inputRePass";
            this.inputRePass.Size = new System.Drawing.Size(230, 34);
            this.inputRePass.TabIndex = 16;
            this.inputRePass.UseSystemPasswordChar = true;
            // 
            // reEnterPassword
            // 
            this.reEnterPassword.AutoSize = true;
            this.reEnterPassword.BackColor = System.Drawing.SystemColors.Control;
            this.reEnterPassword.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reEnterPassword.Location = new System.Drawing.Point(65, 232);
            this.reEnterPassword.Name = "reEnterPassword";
            this.reEnterPassword.Size = new System.Drawing.Size(256, 37);
            this.reEnterPassword.TabIndex = 15;
            this.reEnterPassword.Text = "Re-Enter Password";
            // 
            // inputFName
            // 
            this.inputFName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputFName.Location = new System.Drawing.Point(371, 291);
            this.inputFName.Name = "inputFName";
            this.inputFName.Size = new System.Drawing.Size(230, 34);
            this.inputFName.TabIndex = 18;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.BackColor = System.Drawing.SystemColors.Control;
            this.firstName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstName.Location = new System.Drawing.Point(65, 287);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(156, 37);
            this.firstName.TabIndex = 17;
            this.firstName.Text = "First Name";
            // 
            // inputLName
            // 
            this.inputLName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputLName.Location = new System.Drawing.Point(371, 349);
            this.inputLName.Name = "inputLName";
            this.inputLName.Size = new System.Drawing.Size(230, 34);
            this.inputLName.TabIndex = 20;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.BackColor = System.Drawing.SystemColors.Control;
            this.lastName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(65, 345);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(152, 37);
            this.lastName.TabIndex = 19;
            this.lastName.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(65, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 37);
            this.label2.TabIndex = 21;
            this.label2.Text = "Date of Birth";
            // 
            // inputDOB
            // 
            this.inputDOB.Checked = false;
            this.inputDOB.CustomFormat = "dd-MM-yyyy";
            this.inputDOB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputDOB.Location = new System.Drawing.Point(371, 400);
            this.inputDOB.Name = "inputDOB";
            this.inputDOB.Size = new System.Drawing.Size(230, 34);
            this.inputDOB.TabIndex = 22;
            // 
            // userType
            // 
            this.userType.AutoSize = true;
            this.userType.BackColor = System.Drawing.SystemColors.Control;
            this.userType.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userType.Location = new System.Drawing.Point(65, 453);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(147, 37);
            this.userType.TabIndex = 23;
            this.userType.Text = "User-Type";
            // 
            // inputType
            // 
            this.inputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputType.FormattingEnabled = true;
            this.inputType.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.inputType.Location = new System.Drawing.Point(371, 453);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(230, 36);
            this.inputType.TabIndex = 24;
            // 
            // NewUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 583);
            this.Controls.Add(this.inputType);
            this.Controls.Add(this.userType);
            this.Controls.Add(this.inputDOB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputLName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.inputFName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.inputRePass);
            this.Controls.Add(this.reEnterPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Name = "NewUserScreen";
            this.Text = "SimpleTextEditor - New User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewUserScreen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox inputRePass;
        private System.Windows.Forms.Label reEnterPassword;
        private System.Windows.Forms.TextBox inputFName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox inputLName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker inputDOB;
        private System.Windows.Forms.Label userType;
        private System.Windows.Forms.ComboBox inputType;
    }
}