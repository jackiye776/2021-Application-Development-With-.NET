# Assignment 2 - Simple Text Editor Application

**Application by Jackie Lim**

**Date Updated:- 10/10/2021**

------

## The Application

- Developed in Microsoft Visual Studio 2019 (using C# and NETCOREAPP 3.1)
- A simple application that uses windows form
- SimpleTextEditor.exe is stored in */SimpleTextEditor/bin/debug/netcoreapp3.1*

------

## **How To Use**

1. Find the program in:- */SimpleTextEditor/bin/debug/netcoreapp3.1/SimpleTextEditor.exe*
2. When you first run the application, you are required to login or create a new user. Login credentials are stored in "login.txt" and can be found within:- */SimpleTextEditor/bin/Debug/netcoreapp3.1/login.txt*
3. Enter as followed to gain access to the text editor functionality

   - View - Username: user1 | Password: password123 
   - Edit - Username: user2 | Password: 321password 
4. After logging in, depending on the user's type, you can now manipulate text, open text files and save text files

------

## Other Notes

- All new users are stored in */SimpleTextEditor/bin/Debug/netcoreapp3.1/login.txt*

------

## **References**

### Images

**Every other icons provided by the subject**

Subject 31927 (2021). [Image] UTS Online. https://online.uts.edu.au/

**Help Icon**

Isabelle, T. (2014). *10 Help Icon Blue Images* [Image]. Newdesignfile. http://www.newdesignfile.com/post_help-icon-blue_361996/



### **Online Sources**

**Default DateTimePicker**

ElektroStudios. (2013, October 19). Ensure that control Format property is properly set to use a custom format: DateTimePicker1.Format = DateTimePickerFormat.Custom. Then this is how you [Comment on "Set default format of datetimepicker as dd-MM-yyyy"] *Stackoverflow*. https://stackoverflow.com/questions/19466805/set-default-format-of-datetimepicker-as-dd-mm-yyyy

**Check if combo box is null**

liuzhidong. (2014, November 6). The code should work. Although I will also set SelectedIndex as well...... if (this.comboBox1.SelectedItem == null || this.comboBox1.SelectedIndex == -1). you mean "When [Comment on "Check if combobox value is empty"] *Stackoverflow.* https://stackoverflow.com/questions/26773729/check-if-combobox-value-is-empty

**Writing to txt file via StreamWriter**

Thompson, B. (2021, October 7). *C# Stream Tutorial: StreamReader, StreamWriter with Example*. Guru99. https://www.guru99.com/c-sharp-stream.html

**Read and Open txt file**

Patel, H. (2019, Feburary 27). *Read Text File in C# / Display Text File to RichTextBox* [Video]. YouTube https://www.youtube.com/watch?v=B6oZOoiNpVU

**Saving user's file as RTF**

Microsoft. (2021). *RichTextBox.SaveFile Method*. https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.richtextbox.savefile?view=windowsdesktop-5.0

**RichTextBox Copy, Cut and Paste methods**

Microsoft. (2021). *TextBoxBase.Cut Method*. https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.textboxbase.cut?view=windowsdesktop-5.0

**Selection font property for Bold, Italics & Underline**

Microsoft. (2021). *RichTextBox.SelectionFont Property*. https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.richtextbox.selectionfont?view=windowsdesktop-5.0

**Applying Bold, Italics & Underline on selected text together**

Dhamodaran, S. (2020, April 7). *C# RichTextBox Explained with Examples*. Coding Examples. https://coding-examples.com/csharp/c-richtextbox-explained-with-examples/#6-set-richtextboxs-bold-italic-underline-using-selectionfont

**Font Size Changed**

Bodul. (2018, October 13). private void toolStripComboBox1_Click(object sender, EventArgs e) { toolStripComboBox1.ComboBox.SelectionChangeCommitted += ComboBoxOnSelectionChangeCommitted; } private void ComboBoxOnSelectionChangeCommitted(object o, EventArgs eventArgs) {  switch (toolStripComboBox1.SelectedIndex) { case [Comment on "How to use combobox to change the richTextBox font size"] *Stackoverflow.* https://stackoverflow.com/questions/52793237/how-to-use-combobox-to-change-the-richtextbox-font-size

**Disable Buttons in Forms**

Fredou. (2011, July 17). DownloadButton.Enabled = false; [Comment on "How to grey out / disable a button control in Win Forms?"] *Stackoverflow*. https://stackoverflow.com/questions/6724224/how-to-grey-out-disable-a-button-control-in-win-forms/6724234

**Closing Application using Event Handlers**

Michael. (n.d.) Well this will be four years too late, however, I thought I'd post this for anyone else who runs into [Comment on "Debug not stopping after form closing in Visual Studio"] *py4u.net* https://www.py4u.net/discuss/776169

