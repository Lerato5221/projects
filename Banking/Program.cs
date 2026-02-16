using System;
using Banking.Functions;
using System.Collections.Generic; 

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.WriteLine("Welcome to MBU Banking.");
                Console.WriteLine();
                Console.WriteLine("Please select an Option below.");
                Console.WriteLine("1 - Login.");
                Console.WriteLine("2 - Open an account.");
                Console.WriteLine("3 - Exit.");

                Console.WriteLine("Option: ");
                option = int.Parse(Console.ReadLine()?? "0");


                switch (option)
                {
                    case 1:
                        Bank_funtions.Login();
                        break;

                    case 2:
                        //
                        break;

                    case 3:
                        Console.WriteLine("Thank your visit.");
                        break;

                }
            } while (option != 3);
        }
    }
}