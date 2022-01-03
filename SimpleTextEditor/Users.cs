using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleTextEditor
{
    public class Users
    {
        public LinkedList<Users> usersList = new LinkedList<Users>(); // Linked Lists
        public string userLoginName { get; set; } // User's username / login name
        public string userLoginPassword { get; set; } // User's login password
        public string userType { get; set; } // User's type either EDIT / VIEW
        public string userFName { get; set; } // User's first name
        public string userLName { get; set; } // User's last name
        public string userDOB { get; set; } // User's date of birth
           
        private string[] fields; // fields to store split text from file content
        private Users tempUser; // temporary object of Users

        public void loadUsers()
        {
            StreamReader fileContent = new StreamReader("login.txt");

            while (!fileContent.EndOfStream) 
            {
                fields = splitText(fileContent); // call splitText method passing file
                // Fields: (Username, Password, Type, FName, LName, DOB) from .txt file
                // Add all users from file to linkedlist
                LinkedListNode<Users> tempUser = usersList.AddLast(new Users() { 
                    userLoginName = fields[0],                
                    userLoginPassword = fields[1], 
                    userType = fields[2], 
                    userFName = fields[3], 
                    userLName = fields[4], 
                    userDOB = fields[5] 
                });
            }
            fileContent.Close(); // Closes the file
        }
        
        public string[] splitText(StreamReader file) // method to split the text from "login.txt"
        {
            tempUser = new Users(); 
            string line = file.ReadLine(); // read the line
            return fields = line.Split(','); // split line with , creating substrings stored in fields array
        }

        public override string ToString() // To display user's Username / Login Name
        {
            return String.Format("{0}", userLoginName);
        }

        public string[] userDetails(string name) // Used in TextEditorScreen form
        {
            string[] tempUser = new string[2]; // array to store data of username and type

            StreamReader fileContent = new StreamReader("login.txt");
            while (!fileContent.EndOfStream)
            {
                fields = splitText(fileContent); // call splitText method passing file
                if(fields[0] == name) // find name from file and passes it back
                {
                    tempUser[0] = fields[0]; // Username
                    tempUser[1] = fields[2]; // Type
                }
            }
            fileContent.Close(); // closes the file
            return tempUser; // return array
        }

        public bool checkLogin(string name, string pass) // Checks login credientals. Used in LoginScreen
        {
            // if username and password is correct, returns true. else false
            foreach (Users user in usersList)
            { 
                if (user.userLoginName == name && user.userLoginPassword == pass) 
                {
                    return true;
                }        
            }
            return false;
        }

        public bool checkUserNameExists(string userName) // Checks if username exists already. Used in NewUserScreen
        {
            // if username exists in list returns true. else false
            foreach (Users user in usersList)
            {
                if (user.userLoginName == userName)
                {
                    return true;
                }
            }
            return false;
        }

        public bool addUser(string logName, string logPass, string type, string FName, string LName, string DOB) // Used in NewUserScreen
        {
            try // Adds user to the linkedlist and file
            {
                usersList.AddLast(new Users() { userLoginName = logName, userLoginPassword = logPass, userType = type, userFName = FName, userLName = LName, userDOB = DOB });
                StreamWriter fileContent = File.AppendText("login.txt");
                fileContent.WriteLine($"{logName},{logPass},{type},{FName},{LName},{DOB}"); // Writes to file
                fileContent.Close();
                return true;
            } 
            catch (Exception)
            {
                return false;
            }
        }
    }
}
