using System;
using Banking.Functions;
using System.Collections.Generic;
using Banking.Classes;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<Person> Clients = new List<Person>(); // List to hold clients

            // Load data in start-up
            Bank_funtions.LoaderFiler(Clients);
            int option;

            

            do
            { // Menu
                Console.WriteLine("Welcome to MBU Banking.");
                Console.WriteLine();
                Console.WriteLine("Please select an Option below.");
                Console.WriteLine("1 - Login.");
                Console.WriteLine("2 - Open an account.");
                Console.WriteLine("3 - Exit.");

                Console.Write("Option: ");
                option = int.Parse(Console.ReadLine()?? "0");


                switch (option)
                {
                    case 1:
                        Bank_funtions.Login(Clients);
                        Console.WriteLine();
                        break;

                    case 2:
                        Bank_funtions.OpenAccount(Clients);
                        Console.WriteLine();
                        break;

                    case 3:
                    Bank_funtions.WriteToFile(Clients);
                        Console.WriteLine("Thank your visit.");
                        Console.WriteLine();
                        break;

                }
            } while (option != 3);
        }
    }
}