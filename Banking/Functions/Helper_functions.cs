// This are helper funciton
using System;

namespace Banking.Helper
{
    class Helper_Function
    {
        // Account number generator.
        public static string AccountNumber_Generator()
            {
                Random random = new Random();
                HashSet<int> digits = new HashSet<int>();

                while (digits.Count < 8)
                {
                    digits.Add(random.Next(0, 10)); // digits 0–9
                }

                return string.Join("", digits);
            }
    }
}