// This is where all the account computations happen.
using System;
using System.ComponentModel;
using System.Data.Common;


// Linked classes
using Banking;
using Banking.Classes;
namespace Banking.Computations
{
    class Computation_Functions
    {   
        // Deposit cash
        public static void Deposit(Person selectedPerson)
        {
            double DepositAmount;

            Console.WriteLine("How Much would you like to deposit.");
            Console.WriteLine("Enter amount: .");
            DepositAmount = double.Parse(Console.ReadLine()?? "0");

            if (DepositAmount == 0)
            {
                Console.WriteLine("Please insert an amount");
                return;
            } else
            {
                selectedPerson.Amount += DepositAmount;
            }

            Console.WriteLine($"You have succesfully deposit R {DepositAmount}.");
            Console.WriteLine($"New Balance R {selectedPerson.Amount}.");
        }

        public static void Withdraw(Person selectedPerson)
        {
        
            Console.WriteLine("How much would you like to withdraw?");
            Console.Write("Enter amount: ");

            if (!double.TryParse(Console.ReadLine(), out double withdrawAmount))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (withdrawAmount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be more than 0.");
                return;
            }

            if (withdrawAmount > selectedPerson.Amount)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }

            selectedPerson.Amount -= withdrawAmount;

            Console.WriteLine($"You have successfully withdrawn R {withdrawAmount:f2}");
            Console.WriteLine($"Remaining Balance: R {selectedPerson.Amount:f2}");
            
        }

        public static void ViewBalance(Person SelectedPerson)
        {
            Console.WriteLine("---------------Account Info---------------");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Account holder: {SelectedPerson.FullName}");
            Console.WriteLine($"Account holder: {SelectedPerson.Amount:f2}");
            Console.WriteLine();
        
        }
    }
}
