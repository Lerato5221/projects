using System;
using System.ComponentModel;

// Links
using Banking.Classes;
using Banking.Messages;
using Banking.Helper;
using Banking.Computations;
using System.Reflection.Metadata;

namespace Banking.Functions
{
    class Bank_funtions
    {

        // Open account
        public static void OpenAccount(List<Person> Clients)
        {

            // Function to Open an account
            Console.WriteLine("welcome to MBU Back");
            Console.WriteLine();
            Console.WriteLine("Please provide the following.");
            Console.Write("Fullname: ");
            String fullname = Console.ReadLine()?? "";

            Console.Write("Occupation: ");
            String occupation = Console.ReadLine()?? "";

            Console.Write("Gender Male/Female: ");
            string gender = Console.ReadLine()?? "";

            Console.Write("Create 4 digit pin: ");
            int pin;

            // Pin Logic
            while(!int.TryParse(Console.ReadLine(), out pin) || pin < 1000 || pin > 9999)
            {
                Console.Write("Invalid PIN. Enter a 4 digit pin");
            }

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine()?? "0");

            // Generating account
            string G_account = Helper_Function.AccountNumber_Generator(); // Generate an account in a String format using Helper function.

            int account = Convert.ToInt32(G_account); // Converts the generated string account into an int

            // ) deposits to the amount
            double amount = 0;

            Person person =  new Classes.Person(fullname, occupation,  gender, account, amount, pin, age);

            Clients.Add(person);

            Bank_Messages.AccountConfirmation(person); // Calls the confirmation message.
        }

        // Login function
        public static void Login(List<Person> Clients)
        {   
            Console.WriteLine("Welcome.");
            Console.WriteLine("Please insert the following.");
            Console.WriteLine();

            Console.WriteLine("Account number: ");
            int account_number = int.Parse(Console.ReadLine()?? "0");
            bool account_found = false;
            int Pin_number;

            foreach( Person p in Clients)
            {
                if (account_number == p.AccountNumber)
                {
                    account_found = true;
                }
            }

            // if account found
            if (account_found)
            {
                Console.Write("Enter pin: ");

                while (!int.TryParse(Console.ReadLine(), out Pin_number) 
                    || Pin_number < 1000 
                    || Pin_number > 9999)
                {
                    Console.Write("Invalid PIN. Enter a 4 digit number: ");
                }

                foreach( Person p in Clients)
                {
                    int choice;
                    if (Pin_number == p.Pin)
                    {
                        
                        Console.WriteLine($"Welcome {p.FullName}.");
                        Console.WriteLine();
                        Console.WriteLine("Please choose an option.");
                        Console.WriteLine("1 - Deposit.");
                        Console.WriteLine("2 - Withdraw.");
                        Console.WriteLine("3 - View Balamce.");
                        Console.WriteLine();

                        choice = int.Parse(Console.ReadLine()?? "0");

                        switch (choice)
                        {
                            case 1:
                                Computation_Functions.Deposit(Clients);
                                break;
                        }
                    }
                }
            } else
            {   
                Console.WriteLine("Account number not found.");
                Console.WriteLine("Would you like to Open an account? Y/N.");

                string Open_Account = Console.ReadLine()?? "";

                if (Open_Account == "Y" || Open_Account == "y")
                {
                    OpenAccount(Clients);
                }
                
            }
        
        }
    }
}

