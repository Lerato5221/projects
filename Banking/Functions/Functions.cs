using System;
using System.ComponentModel;

// Links
using Banking.Classes;
using Banking.Messages;
using Banking.Helper;

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
            int pin = int.Parse(Console.ReadLine()?? "0");

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine()?? "0");

            // Generating account
            string G_account = Helper_Function.AccountNumber_Generator(); // Generate an account in a String format using Helper function.

            int account = Convert.ToInt32(G_account); // Converts the generated string account into an int



            Person person =  new Classes.Person(fullname, occupation,  gender, account, pin, age);

            Clients.Add(person);

            Bank_Messages.AccountConfirmation(person); // Calls the confirmation message.
        }

        // Login function
        public static void Login(List<Person> Clients)
        {   
            Person person;


            Console.WriteLine("Welcome.");
            Console.WriteLine("Please insert the following.");
            Console.WriteLine();

            Console.WriteLine("Account number: ");
            int account_number = int.Parse(Console.ReadLine());

            Console.WriteLine("Pin Number: ");
            int Pin_number = int.Parse(Console.ReadLine());

            if (int account_number in )
        
        }
    }
}

