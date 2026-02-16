// This is a message file.
using System;
using Banking.Classes;
using Banking.Functions;


namespace Banking.Messages
{
    class Bank_Messages
    {
        
        // Login message
        public void Login()
        {
            Console.WriteLine("Welcome");
    
        }

        // Confirms that the accouunt is created
        public static void AccountConfirmation(Person person)
        {
        
            // Account creation confirmation
            Console.WriteLine("Account created.");
            Console.WriteLine("Account details.");
            Console.WriteLine();

            Console.WriteLine($"Name:   {person.FullName}");
            Console.WriteLine($"Job :   {person.Occupation}");
            Console.WriteLine($"Age :   {person.Age}");
            Console.WriteLine($"Sex:    {person.Gender}");
            Console.WriteLine($"Pin:    {person.Pin}");
            Console.WriteLine($"Acc #:  {person.AccountNumber}");

            Console.WriteLine("Thank you for choosing us.");
            Console.WriteLine(); 

        }
    }
}
