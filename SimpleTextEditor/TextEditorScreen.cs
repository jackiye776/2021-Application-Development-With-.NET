using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public partial class TextEditorScreen : Form
    {
        Users userManager = new Users();
        private string currentFile = ""; // variable to store opened file's name

        public TextEditorScreen(string userName) //string name, string type
        {
            InitializeComponent();

            userManager.loadUsers(); // load data from "login.txt"
            string[] currentUser; // storage for current user's detail
            currentUser = userManager.userDetails(userName); // Get user's username & user type
            string name = currentUser[0];
            string type = currentUser[1];

            userNameStripTop.Text += name; // User's name is display on top strip

            // Default values for font set at 8
            fontSizeStripTop.Items.Insert(0, "8");
            fontSizeStripTop.SelectedIndex = 0;

            // Disables function depending on user's type
            if(type != "Edit")
            {
                newToolStripMenuItem.Enabled = false;
                saveToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                toolStripLeft.Enabled = false;
                toolStripTop.Enabled = false;
                richTextBox.ReadOnly = true; // Read only to allow user to highlight / copy text
            }
        }

        /* fileToolStripMenuItem */

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "*.txt";
            openFile.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*|RTF Files| *.rtf"; // filters for txt & rtf file / all files
            // Check if user's presses OK and than file name is greater than 0
            if (openFile.ShowDialog() == DialogResult.OK && openFile.FileName.Length > 0)
            {
                currentFile = openFile.FileName; // store filename into a variable to be used for Save button
                richTextBox.Text = File.ReadAllText(openFile.FileName); // display all lines from file into richtextbox
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To Logout?", "Text Editor - Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) // A warning to check if user wants to log out
            {
                new LoginScreen().Show(); // display loginscreen form
                this.Hide(); // hide this screen
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Checks if user wants to open a new file 
            DialogResult result = MessageBox.Show("Create A New File?\nThis Will Delete Unsaved Work", "Text Editor - New File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                currentFile = ""; // store nothing to prevent errors
                richTextBox.Clear(); // clear the richtextbox
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (currentFile != "") // if opened file exists, will save directly to that file
            {
                richTextBox.SaveFile(currentFile, RichTextBoxStreamType.PlainText);
            }
            else // select a file to save to
            {
                saveFile.Filter = "Text Files (*.txt)| *.txt |RTF Files|*.rtf"; // filters for txt & rtf file / all files
                // Check if user's presses OK and than file name is greater than 0
                if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0)
                {
                    richTextBox.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
                    currentFile = saveFile.FileName;
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "*.rtf";
            saveFile.Filter = "Text Files (*.txt)| *.txt |RTF Files|*.rtf"; // Only allow user to save as RTF file

            // Check if user's presses OK and than file name is greater than 0
            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0)
            {
                richTextBox.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
                currentFile = saveFile.FileName;
            }
        }

        /* editToolStripMenuItem */

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox.SelectionLength > 0) // check if selectionlength is graeter than 0
            {
                richTextBox.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0) // check if selectionlength is graeter than 0
            {
                richTextBox.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if there is an item in clipboard if so continue
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                richTextBox.SelectionStart = richTextBox.SelectionStart + richTextBox.SelectionLength;
            }
            richTextBox.Paste();
        }

        /* helpToolStripMenuItem */

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutScreen().Show(); // open up a new window to display the aboutscreen
        }

        /* toolStripTop */

        private void newButtonStripTop_Click(object sender, EventArgs e)
        {
            // Checks if user wants to open a new file 
            DialogResult result = MessageBox.Show("Create A New File?\nThis Will Delete Unsaved Work", "Text Editor - New File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                currentFile = ""; // store nothing to prevent errors
                richTextBox.Clear(); // clear the richtextbox
            }
        }

        private void openButtonStripTop_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "*.txt";
            openFile.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*|RTF Files| *.rtf"; // filters for txt & rtf file / all files
            // Check if user's presses OK and than file name is greater than 0
            if (openFile.ShowDialog() == DialogResult.OK && openFile.FileName.Length > 0)
            {
                currentFile = openFile.FileName; // store filename into a variable to be used for Save button
                richTextBox.Text = File.ReadAllText(openFile.FileName); // display all lines from file into richtextbox
            }
        }

        private void saveButtonStripTop_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog(); 
            if (currentFile != "") // if opened file exists, will save directly to that file
            {
                richTextBox.SaveFile(currentFile, RichTextBoxStreamType.PlainText);
            }
            else // select a file to save to
            {
                saveFile.Filter = "Text Files (*.txt)| *.txt |RTF Files|*.rtf"; // filters for txt & rtf file / all files
                // Check if user's presses OK and than file name is greater than 0
                if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0)
                {
                    richTextBox.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
                    currentFile = saveFile.FileName;
                }
            }
        }

        private void saveAsButtonStripTop_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.DefaultExt = "*.rtf"; 
            saveFile.Filter = "Text Files (*.txt)| *.txt |RTF Files|*.rtf"; // Only allow user to save as RTF file

            // Check if user's presses OK and than file name is greater than 0
            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0)
            {
                richTextBox.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
                currentFile = saveFile.FileName;
            }
        }

        // Reference:- https://coding-examples.com/csharp/c-richtextbox-explained-with-examples/#6-set-richtextboxs-bold-italic-underline-using-selectionfont
        private void boldButtonStripTop_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox.SelectionFont; // Take selected text's font 
            if (currentFont != null) // check if text has been selected
            {
                // XOR operation = ^
                // By clicking bold button, will remove it or add it in without removing the other fontstyles already applied
                richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, currentFont.Style ^ FontStyle.Bold);
            }
        }

        private void italicsButtonStripTop_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox.SelectionFont; // Take selected text's font 
            if (currentFont != null) // check if text has been selected
            {
                // By clicking italic button, will remove it or add it in without removing the other fontstyles already applied
                richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, currentFont.Style ^ FontStyle.Italic);
            }
        }

        private void underLineButtonStripTop_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox.SelectionFont; // Take selected text's font 
            if (currentFont != null) // check if text has been selected
            {
                // By clicking underline button, will remove it or add it in without removing the other fontstyles already applied
                richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, currentFont.Style ^ FontStyle.Underline);
            }
        }
        
        private void fontSizeStripTop_Click(object sender, EventArgs e) 
        {
            // When user selects a size, will check if change is committed and then change with it
            fontSizeStripTop.ComboBox.SelectionChangeCommitted += fontChanged;
        }

        private void fontChanged(object o, EventArgs e)
        {
            Font currentFont = richTextBox.SelectionFont; // Take selected text's font 
            int fontSize = Convert.ToInt32(fontSizeStripTop.SelectedItem); // Convert selecteditem from combo box into int
            richTextBox.SelectionFont = new Font(currentFont.FontFamily, fontSize, currentFont.Style); // change selected text to size
        }

        private void helpButtonStripTop_Click(object sender, EventArgs e)
        {
            new AboutScreen().Show(); // open up a new window to display the aboutscreen
         }

        /* toolStripLeft */

        private void cutButtonStripLeft_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0) // check if selectionlength is graeter than 0
            {
                richTextBox.Cut();
            }
        }

        private void copyButtonStripLeft_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0) // check if selectionlength is graeter than 0
            {
                richTextBox.Copy();
            }
        }

        private void pasteButtonStripLeft_Click(object sender, EventArgs e)
        {
            // Check if there is an item in clipboard if so continue
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true) 
            {
                richTextBox.SelectionStart = richTextBox.SelectionStart + richTextBox.SelectionLength;
            }
            richTextBox.Paste();
        }

        // If exit button is pressed / suddenly closed event hanlder will properly exit the application
        private void TextEditorScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
