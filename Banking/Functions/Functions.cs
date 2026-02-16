using System;
using System.Reflection.Metadata.Ecma335;
using Banking.Classes;

namespace Banking.Functions
{
    class Bank_funtions
    {

        // Open account
        

        public static  Person OpenAccount()
        {
            String fullname; 
            String Occupation; 
            Char Gender; 
            int pin; 
            int age;

            // Function to Open an account
            Console.WriteLine("welcome to MBU Back");
            Console.WriteLine("Please provide the following.");
            Console.Write("Fullname: ");
            fullname = Console.ReadLine()?? "";

            Console.Write("Occupation: ");
            Occupation = Console.ReadLine()?? "";

            Console.Write("Gender M/F: ");
            Gender = Console.ReadLine()[0];

            Console.Write("Create 4 digit pin: ");
            pin = int.Parse(console)




            
            

            Person person = new Person(fullname, Occupation,  Gender, int pin, int age);

            return person;
            
        }

        // Login function
        public static void Login()
        {   
            long AccountNumber;
            int Pin;

            Console.WriteLine("Welcome.");
            Console.WriteLine("Please insert the following.");
            Console.WriteLine();

            Console.WriteLine("Account number: ");
            // Try-catch to ensure the number is double
            while(!long.TryParse(Console.ReadLine(), out AccountNumber))
            {
                Console.WriteLine("Invalid input, Please enter valid number");
            }
            Console.WriteLine("Pin: ");
            while(!int.TryParse(Console.ReadLine(), out Pin))
            {
                Console.WriteLine("Invalid input, Please enter valid number");
            }
        
        }
    }
}

