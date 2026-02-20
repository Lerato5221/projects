// This is where all the account computations happen.
using System;

// Linked classes
using Banking;
using Banking.Classes;
namespace Banking.Computations
{
    class Computation_Functions
    {   
        // Deposit cash
        public static void Deposit(Person Clients)
        {
            //Person p;

            double deposit_amount;

            foreach(Person p in Clients)
            {
                Console.Write("Enter amount:");
                deposit_amount = double.Parse(Console.ReadLine());

                    // Add amount to the account.
                if ( deposit_amount > 0)
                {
                        deposit_amount += p.Amount;
                }
            }
        }
    }
}
