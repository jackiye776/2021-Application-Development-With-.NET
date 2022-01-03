using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Security;

/* 
 * SimpleBankSystem Application by Jackie Lim (13543778)
 * 
 * README.md is included with step by step on how to use the system and a list of complete references used.
 * 
 * The Sender's Email (The Program / System)
 * Email:- tempappnet@gmail.com
 * PW:- UTSbank1
 * 
 * Reference:-
 * .NET Application Development Lecture Slides - Sharma, N. (2021). [Subject 31927 lecture notes]. UTS Online. https://online.uts.edu.au/
 * Delete File - Beniwal, D. (2020, March 7). How to Delete a File in C#. c-sharpcorner. https://www.c-sharpcorner.com/UploadFile/dbeniwal321/how-to-delete-a-file-in-C-Sharp/
 * Catching Exceptions - Hanselman, S. [@shanselman], & Havens, K. [@gotheap]. (2019, September 24). Object Oriented Programming: Catching Exceptions | C# 101 [19 of 19] [Video]. YouTube. https://www.youtube.com/watch?v=INfLHh3TDkk&list=PLS3nJPQcKNCQT4Ig11AAnoeeiVM0I-PzB&index=4  
 * Check if File Exists - Microsoft. (2021). File.Exists(String) Method. https://docs.microsoft.com/en-us/dotnet/api/system.io.file.exists?view=net-5.0
 * Send Email - P, R. (2020, September 7).   Send Email in C#. c-sharpcorner. https://www.c-sharpcorner.com/article/sending-email-using-c-sharp/
 * Find Index in List - Microsoft. (2021). List<T>.FindIndex Method. https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.findindex?view=net-5.0#System_Collections_Generic_List_1_FindIndex_System_Predicate__0__
 * Masking Password - Eberle, A. (2017, February 14). C#: How To Replace Letters With Asterisks In Console - Password Protection [Video]. YouTube. https://www.youtube.com/watch?v=sFgQCEzqQ20
 * File Count in Folder - Rahul. (2010, February 11). You can use the Directory.GetFiles method. Also see Directory.GetFiles Method (String, String, SearchOption). You can specify the search option in [Comment on “File count from a folder"]. Stackoverflow. https://stackoverflow.com/questions/2242564/file-count-from-a-folder
 * Get Current Directory - Aloisdg. (2018, May 2018). System.AppContext.BaseDirectory. This is the prefered replacement for AppDomain.CurrentDomain.BaseDirectory in .net core (at least until the API appears for AppDomain, if [Comment on “File count from a folder"]. Stackoverflow. https://stackoverflow.com/questions/50628687/how-to-get-a-directory-path-to-the-debug-folder
 *
 */

namespace SimpleBankSystem
{
    public class Account
    {
        private int accountNumber; // Account's unique accont number
        private string firstName; // Account's first name
        private string lastName; // Account's last name
        private string address; // Account's address
        private string email; // Account's email
        private int phone; // Account's phone number
        private decimal accountBalance; // Account's account balance
        private ArrayList transaction = new ArrayList(); // An ArrayList to store all the customer's transaction

        private static int accountNumberSeed = 100001; // An unique account number assigned to new accounts

        public Account(int accountNumber, decimal accountBalance, string firstName, string lastName, string address, int phone, string email) // Constructor
        {
            if (accountNumber != 0) // Checks if accoutNumber is not equal to 0
            {
                this.accountNumber = accountNumber; // Retrieve account number from file
            }
            else
            {
                this.accountNumber = generateAccountNumber(); // User's UNIQUE account number
            }
            this.accountBalance = accountBalance; // Account's account balance
            this.firstName = firstName; // Account's first name
            this.lastName = lastName; // Account's last name
            this.address = address; // Account's address
            this.phone = phone; // Account's phone number
            this.email = email; // Account's email
        } // Account Constructor

        private int generateAccountNumber() // Generates unique account number via a do while loop
        {
            do
            {
                accountNumberSeed++; // IF accountNumberSeed file exists in folders, increment accoutNumberSeed by 1
            } while (File.Exists($"{accountNumberSeed}.txt"));
            return accountNumberSeed; // Returns value when a number does not exist in the folders
        } // generateAccountNumber()

        public void addDetails() // Create a .txt and write inside it with the details below
        {
            File.WriteAllText($"{this.accountNumber}.txt",
                            $"AccountNo|{this.accountNumber}\n" +
                            $"Balance|{this.accountBalance}\n" +
                            $"First Name|{this.firstName}\n" +
                            $"Last Name|{this.lastName}\n" +
                            $"Address|{this.address}\n" +
                            $"Phone|{this.phone}\n" +
                            $"Email|{this.email}\n");
        } // addDetails()        

        public void deposit(decimal amount, string type) // Deposit 'x' amount from account's balance 
        {
            if (amount >= 0) // If deposit is greater than or equal to 0 will deposit unless user entered a negative value
            {
                this.accountBalance += amount;
                addTransaction(amount, type); // call addTransaction method and passes the amount and type (deposit)
                Console.WriteLine("\n\n\n\t\t\t     Deposit Successful!");
            }
            else
            {
                Console.WriteLine("\n\n\n\t\t\t     Cannot deposit negative amount!");
            }
        } // deposit()

        public void withdraw(decimal amount, string type) // Withdraw 'x' amount from account's balance 
        {
            if (amount >= 0) // If deposit is greater than or equal to 0 will withdraw but only if value is not negative OR account has sufficient funds
            {
                if (accountBalance >= amount)
                {
                    this.accountBalance -= amount;
                    addTransaction(amount, type); // call addTransaction method and passes the amount and type(withdraw)
                    Console.Write("\n\n\n\t\t\t     Withdraw Successful!");
                }
                else
                {
                    Console.WriteLine("\n\n\n\t\t\t     Cannot withdraw, you do have not enough funds!");
                }
            }
            else
            {
                Console.WriteLine("\n\n\n\t\t\t     Cannot withdraw negative amount!");
            }
        } // wihtdraw()

        public void addTransaction(decimal amount, string type) // Accepts amount & "transaction type" which is withdraw / deposit
        {
            if (transaction.Count >= 5)
            {
                transaction.RemoveAt(0); // Remove the first item of the array
            }
            transaction.Add($"{DateTime.Now.ToShortDateString()}|{type}|{amount}|{accountBalance}"); // Adds transaction to ArrayList transaction

            addDetails(); // Call addDetails method to reenter the user's current details (updates balance)

            foreach (string item in this.transaction)
            {
                File.AppendAllText($"{this.accountNumber}.txt", $"{item}\n"); // Appends the transaction into account's file
            }
        } // addTransaction()

        public int getAccountNumber()
        {
            return this.accountNumber; // Returns account number
        } // getAccountNumber()

        public bool sendEmail(string transactions, string mailing) // To send email when requested / obligated to the user's email 
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("tempappnet@gmail.com"); // The Bank's email
                message.To.Add(new MailAddress($"{this.email}")); // Receiver's / user's email
                message.IsBodyHtml = true;
                if (mailing == "create") // When using account creation
                {
                    message.Subject = "Simple Bank - Account Creation"; // Email's subject
                    message.Body = // Email's body
                        $"Welcome to Simple Bank! Below is your account details: <br><br>" + // "<br>" used to put message on new line 
                        $"Account Details <br>" +
                        $"Account No: {this.accountNumber} <br>" +
                        $"First Name: {this.firstName} <br>" +
                        $"Last Name: {this.lastName} <br>" +
                        $"Address: { this.address} <br>" +
                        $"Phone: {this.phone} <br>" +
                        $"Email: {this.email} <br>";
                }
                else if (mailing == "statement") // When using account statement
                {
                    message.Subject = "Simple Bank - Account Statement"; // Email's subject
                    message.Body = // Email's body
                        $"Account No: {this.accountNumber}<br>" +
                        $"Summary of your last five transactions: <br><br>" +
                        $"Account Statement<br>" +
                        $"{transactions}"; 
                }
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; // gmail host (for the sender)
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("tempappnet@gmail.com", "UTSbank1"); // Sender's credentials
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                Console.WriteLine("\n\t\t\t     Email Sent Sucessfully!");
                return true; 
            }
            catch (Exception) { return false; } 
        } // sendEmail()

    } // class Account

    public class BankManager
    {
        List<Account> AccountList = new List<Account>(); // To store all accounts created into a List
        private string correct; // User's input for (y/n)
        private int select; // User's input for main menu
        private bool accountsRetrieved = false; // Bool value to check if accounts has been retrieved or not
        private int listAccessor = 0; // To access AccountList
        private int index; // Index of AccountList

        /* -- Program Functionality -- */

        public void mainMenu()
        {
            if (!accountsRetrieved) { retrieveAccount(); } // Retrieve all accounts only once
            do
            {
                Console.Clear(); // clear console screen
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |             WELCOME TO SIMPLE BANKING SYSTEM            |");
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |                        MAIN MENU                        |");
                Console.WriteLine("\t\t\t |     1. Create a new account                             |");
                Console.WriteLine("\t\t\t |     2. Search for an account                            |");
                Console.WriteLine("\t\t\t |     3. Deposit                                          |");
                Console.WriteLine("\t\t\t |     4. Withdraw                                         |");
                Console.WriteLine("\t\t\t |     5. A/C statement                                    |");
                Console.WriteLine("\t\t\t |     6. Delete account                                   |");
                Console.WriteLine("\t\t\t |     7. Exit                                             |");
                Console.WriteLine("\t\t\t ===========================================================");
                Console.Write("\t\t\t |     Enter your choice (1-7): ");
                int choiceCursorX = Console.CursorTop;
                int choiceCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t   |");
                Console.WriteLine("\t\t\t ===========================================================");
                Console.Write("\t\t\t ");
                int errorCursorX = Console.CursorTop;
                int errorCursorY = Console.CursorLeft;

                try
                {
                    Console.SetCursorPosition(choiceCursorY, choiceCursorX);
                    select = Convert.ToInt32(Console.ReadLine().Trim()); // User enter's number between 1 to 7
                    switch (select)
                    {
                        case 1:
                            createAccount(); 
                            Console.ReadKey();
                            break;
                        case 2:
                            searchAccount();
                            Console.ReadKey();
                            break;
                        case 3:
                            depositAccount();
                            Console.ReadKey();
                            break;
                        case 4:
                            withdrawAccount();
                            Console.ReadKey();
                            break;
                        case 5:
                            statementAccount();
                            Console.ReadKey();
                            break;
                        case 6:
                            deleteAccount();
                            Console.ReadKey();
                            break;
                        case 7:
                            Console.SetCursorPosition(errorCursorY, errorCursorX);
                            Console.Write("Logging out...\n\n");
                            Console.ReadKey();
                            break;
                        default:
                            Console.SetCursorPosition(errorCursorY, errorCursorX);
                            Console.Write("Invalid number, please select a number between 1 to 7");
                            Console.ReadKey();
                            select = 0;
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.SetCursorPosition(errorCursorY, errorCursorX);
                    Console.Write("An error has occured, returning back to main menu");
                    select = 0;
                    Console.ReadKey();
                }
            } while (select == 0);
        } // mainMenu()

        public void createAccount() // Select 1
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |                    CREATE A NEW ACCOUNT                 |");
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |                     ENTER THE DETAILS                   |");
                Console.Write("\t\t\t |     First Name: ");
                int fNameCursorX = Console.CursorTop;
                int fNameCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t                   |");
                Console.Write("\t\t\t |     Last Name: ");
                int lNameCursorX = Console.CursorTop;
                int lNameCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t                   |");
                Console.Write("\t\t\t |     Address: ");
                int addressCursorX = Console.CursorTop;
                int addressCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t                   |");
                Console.Write("\t\t\t |     Phone: ");
                int phoneCursorX = Console.CursorTop;
                int phoneCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t                           |");
                Console.Write("\t\t\t |     Email: ");
                int emailCursorX = Console.CursorTop;
                int emailCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t                           |");  
                Console.WriteLine("\t\t\t ===========================================================");

                Console.SetCursorPosition(fNameCursorY, fNameCursorX);
                string fName = Console.ReadLine().Trim();
                Console.SetCursorPosition(lNameCursorY, lNameCursorX);
                string lName = Console.ReadLine().Trim();
                Console.SetCursorPosition(addressCursorY, addressCursorX);
                string address = Console.ReadLine().Trim();
                Console.SetCursorPosition(phoneCursorY, phoneCursorX);
                string phone = Console.ReadLine().Trim();
                Console.SetCursorPosition(emailCursorY, emailCursorX);
                string email = Console.ReadLine().Trim();

                if (Int32.TryParse(phone, out int number) && phone.Length <= 10) // TryParse used to check if phone number is integers. Also check if there are only less than 10 characters
                {
                    string[] splitEmail = (email.Trim()).Split("@"); // Split email at @. Used to check if there is characters before the @ symbol
                    // Checks if there is any text before the @ symbol & an acceptable domain has been used
                    if (splitEmail[0].Length != 0 && email.Contains("@") && email.Contains("gmail.com") || email.Contains("outlook.com") || email.Contains("uts.edu.au.com"))
                    {
                        Console.Write("\n\t\t\t     Is the information correct (y/n)? ");
                        int correctCursorX = Console.CursorTop;
                        int correctCursorY = Console.CursorLeft;
                        Console.SetCursorPosition(correctCursorY, correctCursorX);
                        correct = Console.ReadLine().ToLower().Trim(); // Ask for user's input either 'y' or 'n'
                        if (correct == "y")
                        {
                            AccountList.Add(new Account(0, 0, fName, lName, address, number, email)); // Create new instance of Account and add it into AccountList
                            AccountList[listAccessor].addDetails(); // Call forth the addDetails method to create a file
                            if (AccountList[listAccessor].sendEmail("", "create")) // Send email and returns if it has succeeded or not 
                            {
                                Console.WriteLine("\n\t\t\t     Account Created! Details will be provided to your email");
                                Console.WriteLine($"\n\t\t\t    Account Number is: {AccountList[listAccessor].getAccountNumber()}");
                                listAccessor++; 
                                select = 0;
                            }
                            else
                            {
                                Console.WriteLine("\n\t\t\t     Invalid Email...");
                                Console.ReadKey();
                            }
                        }
                        else if (correct == "n")
                        {
                            Console.WriteLine("\n\t\t\t     Information is incorrect, please re enter details again...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n\t\t\t    Invalid key, please enter details again...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t     Please enter a valid email or include an '@'...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("\n\t\t\t    Please enter digits between 0 to 9 for phone numbers...");
                    Console.ReadKey();
                }
                Console.Write("\n\t\t\t    Would you like to add another account (y/n)? "); // Ask for user's input either 'y' or 'n'
                correct = Console.ReadLine().ToLower().Trim();
                if (correct == "y") // IF 'y', user can create another account
                {
                    Console.ReadKey();
                    createAccount();
                }
                else if (correct == "n") // IF 'n' goes back to mainmenu
                {
                    select = 0;
                }
                else // If invalid key, returns to main menu
                {
                    Console.WriteLine("\n\t\t\t     Invalid key, returning to main menu");
                    select = 0;
                }
            } while (select == 1);
        } // createAccount()

        public void searchAccount() // Select 2
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |                     SEARCH AN ACCOUNT                   |");
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |                     ENTER THE DETAILS                   |");
                Console.Write("\t\t\t |     Account Number: ");
                int accountNumCursorX = Console.CursorTop;
                int accountNumCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t                   |");
                Console.WriteLine("\t\t\t ===========================================================");

                Console.SetCursorPosition(accountNumCursorY, accountNumCursorX);
                string search = Console.ReadLine().Trim(); // Ask for user's input for account number

                if (search.Length >= 6 && search.Length <= 10) // Checks if user's input is less than 11 or greater than 5
                {
                    if (checkAccountNumber(search)) // checks if file exists of account number
                    {
                        Console.WriteLine("\n\t\t\t     Account found! Details displayed below...");
                        Console.WriteLine("\t\t\t ===========================================================");
                        Console.WriteLine("\t\t\t |                     ACCOUNT DETAILS                     |");
                        readFile(search); // call readFile method to display account details       
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t     Account not found!");
                    }
                }
                else
                {
                    Console.Write("\n\t\t\t     Please enter between 6-10 digits");
                }
                Console.Write("\n\t\t\t     Check for another account (y/n)? ");
                correct = Console.ReadLine().ToLower().Trim(); // Ask for user's input either 'y' or 'n'
                if (correct == "y")
                {
                    Console.ReadKey();
                    searchAccount();
                }
                else if (correct == "n")
                {
                    select = 0;
                }
                else
                {
                    Console.WriteLine("\n\t\t\t     Invalid key, returning to main menu");
                    select = 0;
                }
            } while (select == 2);
        } // searchAccount()

        public void depositAccount() // Select 3
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |                    DEPOSIT TO AN ACCOUNT                |");
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |                     ENTER THE DETAILS                   |");
                Console.Write("\t\t\t |     Account Number: ");
                int accountNumCursorX = Console.CursorTop;
                int accountNumCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t                   |");
                Console.Write("\t\t\t |     Amount $");
                int amountCursorX = Console.CursorTop;
                int amountCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t                           |");
                Console.WriteLine("\t\t\t ===========================================================");

                Console.SetCursorPosition(accountNumCursorY, accountNumCursorX);
                string search = Console.ReadLine().Trim(); // Ask for user's input for account number

                if (search.Length >= 6 && search.Length <= 10) // Checks if user's input is less than 11 or greater than 5
                {
                    if (checkAccountNumber(search)) // checks if file exists of account number
                    {
                        Console.WriteLine("\n\n\t\t\t     Account found! Enter the amount to deposit!");
                        try
                        {
                            Console.SetCursorPosition(amountCursorY, amountCursorX);
                            decimal amount = Convert.ToInt32(Console.ReadLine().Trim()); // Ask for user's input for amount to deposit
                            AccountList[accountListIndex(search)].deposit(amount, "Deposit"); // Use deposit method from Account passing it the amount and string "Deposit"         
                        } 
                        catch
                        {
                            Console.WriteLine("\n\n\n\t\t\t     Please only enter numbers...");
                        }            
                    }
                    else
                    {
                        Console.WriteLine("\n\n\n\t\t\t     Account not found!");
                    }
                }
                else
                {
                    Console.WriteLine("\n\n\n\t\t\t     Please enter between 6-10 digits");
                }
                Console.Write("\t\t\t     Check for another account (y/n)? ");
                correct = Console.ReadLine().ToLower().Trim(); // Ask for user's input either 'y' or 'n'
                if (correct == "y")
                {
                    Console.ReadKey();
                    depositAccount();
                }
                else if (correct == "n")
                {
                    select = 0;
                }
                else
                {
                    Console.WriteLine("\n\t\t\t     Invalid key, returning to main menu");
                    select = 0;
                }
            } while (select == 3);
        } // depositAccount()

        public void withdrawAccount() // Select 4
        {
            do
            {
                Console.Clear();
                Console.Clear();
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |                  WITHDRAW FROM AN ACCOUNT               |");
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |                     ENTER THE DETAILS                   |");
                Console.Write("\t\t\t |     Account Number: ");
                int accountNumCursorX = Console.CursorTop;
                int accountNumCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t                   |");
                Console.Write("\t\t\t |     Amount $");
                int amountCursorX = Console.CursorTop;
                int amountCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t                           |");
                Console.WriteLine("\t\t\t ===========================================================");

                Console.SetCursorPosition(accountNumCursorY, accountNumCursorX);
                string search = Console.ReadLine().Trim(); // Ask for user's input for account number

                if (search.Length >= 6 && search.Length <= 10) // Checks if user's input is less than 11 or greater than 5
                {
                    if (checkAccountNumber(search)) // checks if file exists of account number
                    {
                        Console.WriteLine("\n\n\t\t\t   Account found! Enter the amount to withdraw!");         
                        try
                        {
                            Console.SetCursorPosition(amountCursorY, amountCursorX);
                            decimal amount = Convert.ToInt32(Console.ReadLine().Trim()); // Ask for user's input for amount to withdraw
                            AccountList[accountListIndex(search)].withdraw(amount, "Withdraw"); // Use deposit method from Account passing it the amount and string "Withdraw"         
                        }
                        catch
                        {
                            Console.WriteLine("\n\n\n\t\t\t     Please only enter numbers...");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\n\n\t\t\t     Account not found!");
                    }
                }
                else
                {
                    Console.WriteLine("\n\n\n\t\t\t     Please enter between 6-10 digits");
                }

                Console.Write("\n\t\t\t   Check for another account (y/n)? ");
                correct = Console.ReadLine().ToLower().Trim(); // Ask for user's input either 'y' or 'n'
                if (correct == "y") 
                {
                    Console.ReadKey();
                    withdrawAccount();
                }
                else if (correct == "n")
                {
                    select = 0;
                }
                else
                {
                    Console.WriteLine("\n\t\t\t     Invalid key, returning to main menu");
                    select = 0;
                }
            } while (select == 4);
        } // withdrawAccount()

        public void statementAccount() // Select 5
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |                   VIEW ACCOUNT STATEMENT                |");
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |                     ENTER THE DETAILS                   |");
                Console.Write("\t\t\t |     Account Number: ");
                int accountNumCursorX = Console.CursorTop;
                int accountNumCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t                   |");
                Console.WriteLine("\t\t\t ===========================================================");

                Console.SetCursorPosition(accountNumCursorY, accountNumCursorX);
                string search = Console.ReadLine().Trim(); // Ask for user's input for account number
                string transactions = ""; // Create a temporary string variable to hold "transactions"

                if (search.Length <= 10 && search.Length >= 6) // Checks if user's input is less than 11 or greater than 5
                {
                    if (checkAccountNumber(search)) // Checks if file exists of account number
                    {
                        Console.WriteLine("\n\t\t\t   Account found! The statement is displayed below...");
                        Console.WriteLine("\t\t\t ===========================================================");
                        Console.WriteLine("\t\t\t |                  SIMPLE BANKING SYSTEM                  |");
                        Console.WriteLine("\t\t\t |                     ACCOUNT STATEMENT                   |");

                        readFile(search); // Call readFile method to display account details 
                        // Same method as readFile but used to get transactions only
                        string[] lines = File.ReadAllLines($"{search}.txt");  // Get account number's file and store it into an array
                        foreach (string set in lines)
                        {
                            string[] splits = set.Split('|'); // split string between '|'
                            if (splits.Length == 4) // transactions has 4 substrings so required if statement to check length
                            {
                                Console.WriteLine($"\t\t    Date: {splits[0]} | Transaction Type: {splits[1]} | Amount: {splits[2]} | Balance: {splits[3]}");
                                transactions += $"Date: {splits[0]} | Transaction Type: {splits[1]} | Amount: {splits[2]} | Balance: {splits[3]}<br>"; // append onto transaction string to be sent to sendEmail method
                            }
                        }

                        Console.Write("\n\t\t     Would you like the statement emailed to your Email address (y/n)? ");
                        correct = Console.ReadLine().Trim();
                        if (correct == "y") // Ask for user's input either 'y' or 'n'
                        {
                            AccountList[accountListIndex(search)].sendEmail(transactions, "statement"); // sendEmail method and pass transaction variable with "statement" string
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t     Account not found!\n");
                    }
                }
                else
                {
                    Console.Write("\n\t\t\t    Please enter between 6-10 digits");
                }
                Console.Write("\n\t\t\t    Check for another account (y/n)? "); // Ask for user's input either 'y' or 'n'
                correct = Console.ReadLine().ToLower().Trim();
                if (correct == "y")
                {
                    Console.ReadKey();
                    statementAccount();
                }
                if (correct == "n")
                {
                    select = 0;
                }
                else
                {
                    Console.WriteLine("\n\t\t\t     Invalid key, returning to main menu");
                    select = 0;
                }
            } while (select == 5);
        } // statementAccount()

        public void deleteAccount() // Select 6
        {
            do
            {
                Console.Clear();
                
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |                     DELETE AN ACCOUNT                   |");
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |                     ENTER THE DETAILS                   |");
                Console.Write("\t\t\t |     Account Number: ");
                int accountNumCursorX = Console.CursorTop;
                int accountNumCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t                   |");
                Console.WriteLine("\t\t\t ===========================================================");

                Console.SetCursorPosition(accountNumCursorY, accountNumCursorX);
                string search = Console.ReadLine().Trim(); // Ask for user's input for account number

                if (search.Length >= 6 && search.Length <= 10) // Check if input is between 6 to 10 characters
                {
                    if (checkAccountNumber(search))
                    {
                        Console.WriteLine("\n\t\t\t     Account found! Details displayed below...");
                        Console.WriteLine("\t\t\t ===========================================================");
                        Console.WriteLine("\t\t\t |                     ACCOUNT DETAILS                     |");
                        readFile(search); // Display the file's text to the console

                        Console.Write("\t\t\t   Delete account (y/n)? ");
                        string delete = Console.ReadLine(); // Store user's key
                        if (delete == "y" || delete == "n") // Check if user entered either y / n
                        {
                            if (delete == "y") // If user enter "y" then delete else, break if statement to check for another account
                            {
                                AccountList.RemoveAt(accountListIndex(search)); // Delete within the AccountList as well
                                File.Delete($"{search}.txt"); // Delete file stored in directory
                                listAccessor--; // Reduce the index of the listAccessor when creating new account
                                Console.WriteLine("\n\t\t\t     Account Deleted!");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n\t\t\t     Invalid key...");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\t\t\t     Account not found!\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n\t\t\t     Please enter between 6-10 digits");
                }
                Console.Write("\n\t\t\t     Check for another account (y/n)? "); // Ask for user's input either 'y' or 'n'
                correct = Console.ReadLine().ToLower().Trim(); 
                if (correct == "y")
                {
                    Console.ReadKey();
                    deleteAccount();
                }
                else if (correct == "n")
                {
                    select = 0;
                }
                else
                {
                    Console.WriteLine("\n\t\t\t     Invalid key, returning to main menu");
                    select = 0;
                }
            } while (select == 6);
        } // deleteAccount()

        /* -- Validations / Check / Retrieve -- */

        private void retrieveAccount() // Retrieving all premade accounts and store it into AccountList
        {
            int tempSeed = 100001; // A temporary seed
            int accNums = Directory.GetFiles(Directory.GetCurrentDirectory(), "1*", SearchOption.TopDirectoryOnly).Length; // find amount of accounts in directory

            for (int i = 0; i < accNums; i++)
            {
                File.WriteAllText("tempAccount.txt", ""); // Create the tempAccount.txt file to store account details
                try // Try to find account file else skip it 
                {
                    foreach (string set in File.ReadAllLines($"{tempSeed}.txt")) // Similar to readFile method
                    {
                        string[] splits = set.Split('|');
                        if (splits.Length == 2)
                        {
                            File.AppendAllText("tempAccount.txt", $"{splits[1]} | "); // Add it into one line
                        }
                    }
                    string[] splitUp = File.ReadAllText("tempAccount.txt").Split('|');
                    AccountList.Add(new Account(Convert.ToInt32(splitUp[0]), Convert.ToDecimal(splitUp[1]), splitUp[2], splitUp[3], splitUp[4], Convert.ToInt32(splitUp[5]), splitUp[6])); // Adding "new" accounts / existing accounts back
                }
                catch (Exception) { } 
                listAccessor++; // Increment listAccesor
                tempSeed++; // Increment tempseed
            }
            accountsRetrieved = true; // when true, will stop retrieveAccount method from looping
        }

        public bool validateLogin(string username, string password)
        {
            string validate = ""; // variable to hold validation of "yes" or "no"
            string[] lines = File.ReadAllLines($"login.txt");
            foreach (string set in lines) // Loop through the entire login.txt file first then return true / false;
            {
                string[] splits = set.Split('|'); // split login into 2 substrings
                if (username == splits[0] && password == splits[1])
                {
                    validate = "yes";
                    break; // If found, break immediately
                }
                else
                {
                    validate = "no";
                }
            }
            return validate == "yes"; // Return TRUE if validate equals to "yes" 
        } // validateLogin()

        public bool checkAccountNumber(string number)
        {
            return File.Exists($"{number}.txt"); // Checks if account number file exists in the directory - Return true if exists else false
        } // checkAccountNumber()
        
        public void readFile(string search)
        {
            Console.WriteLine("\t\t\t ===========================================================");

            string[] lines = File.ReadAllLines($"{search}.txt"); // Store account details into an array called lines
            foreach (string set in lines)
            {
                string[] splits = set.Split('|'); // Split text into substrings
                if (splits.Length == 2)
                {
                    Console.Write($"\t\t\t |     {splits[0]}: {splits[1]}"); // Display to console
                    Console.WriteLine("\t\t\t   |");
                }
            }
            Console.WriteLine("\t\t\t ===========================================================");
        } // readFile();

        public int accountListIndex(string search) // Getting index of an account in AccountList and return it
        {
            foreach (var acc in AccountList)
            {

                if (acc.getAccountNumber() == Convert.ToInt32(search))
                {
                    index = AccountList.IndexOf(acc);
                }
            }
            return index;
        }

    } // class SimpleBankSystem

    public class Program {
        public static void Main(string[] args)
        {
            // When program is used, manager can have access to login method & main menu functionality. For orgainsational purposes too
            BankManager manager = new BankManager();
            bool login = false;

            do
            {
                Console.Clear(); // Clears the console screen
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |             WELCOME TO SIMPLE BANKING SYSTEM            |");
                Console.WriteLine("\t\t\t ===========================================================");
                Console.WriteLine("\t\t\t |                 PLEASE LOGIN TO START                   |");
                Console.WriteLine("\t\t\t |                                                         |");                                                       
                Console.Write("\t\t\t |     Username: ");
                int userNameCursorX = Console.CursorTop;
                int userNameCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t\t\t   |");
                Console.Write("\t\t\t |     Password: ");
                int passwordCursorX = Console.CursorTop;
                int passwordCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t\t\t   |");
                Console.WriteLine("\t\t\t |                                                         |");
                Console.WriteLine("\t\t\t ===========================================================");
                Console.Write("\t\t\t |     ");
                int validCursorX = Console.CursorTop;
                int validCursorY = Console.CursorLeft;
                Console.WriteLine("\t\t\t\t\t                   |");
                Console.WriteLine("\t\t\t ===========================================================");

                Console.SetCursorPosition(userNameCursorY, userNameCursorX);
                string loginName = Console.ReadLine();
                Console.SetCursorPosition(passwordCursorY, passwordCursorX);
                SecureString pass = inputPassword();
                string loginPassword = new System.Net.NetworkCredential(string.Empty, pass).Password; 
                if (manager.validateLogin(loginName, loginPassword))
                {
                    login = true;
                    Console.SetCursorPosition(validCursorY, validCursorX);
                    Console.WriteLine("Valid Credentials!... Press Enter");
                    Console.ReadKey();
                    manager.mainMenu();
                }
                else
                {
                    Console.SetCursorPosition(validCursorY, validCursorX);
                    Console.WriteLine("Invalid Credentials!... Press enter to try again");
                    Console.ReadKey();
                }   
            } while (!login);
            Console.ReadKey();
        } // Main()

        private static SecureString inputPassword() // Code by Eberle (2017)
        {
            SecureString pass = new SecureString();
            ConsoleKeyInfo keyinfo;

            do
            {
                keyinfo = Console.ReadKey(true);
                if (!char.IsControl(keyinfo.KeyChar))
                {
                    pass.AppendChar(keyinfo.KeyChar);
                    Console.Write("*");
                }
                else if (keyinfo.Key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    pass.RemoveAt(pass.Length - 1);
                    Console.Write("\b \b");
                }
            } while (keyinfo.Key != ConsoleKey.Enter);
            return pass;
        } // inputPassword()
    }
}
