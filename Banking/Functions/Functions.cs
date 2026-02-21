using System;
using System.Text.Json;
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
            //bool account_found = false;
            int Pin_number;

            Person selectedPerson = null; // No person is selected

            foreach( Person p in Clients) // Checks the account and if found assigns it to selectedPerson.
            {
                if (account_number == p.AccountNumber)
                {
                    selectedPerson = p;
                    break;
                }
            }

            // if not found
            if (selectedPerson == null)
            {
                Console.WriteLine("Account not found.");

                //option to open account
                Console.Write("Would you like to open an account Y/N: ");
                string open_Acount = Console.ReadLine()?? " ";

                if (open_Acount == "Y" || open_Acount == "y")
                {
                    OpenAccount(Clients);
                }

                return;
            }

            Console.WriteLine("Enter PIN: ");
            Pin_number = int.Parse(Console.ReadLine()?? "0");
            
            // 
            if(Pin_number != selectedPerson.Pin)
            {
                Console.WriteLine("Wrong PIN");
                return;
            }

            Console.WriteLine("Login successful!");

            //Options after login
            Console.WriteLine("1 - Deposit.");
            Console.WriteLine("2 - Withdraw.");
            Console.WriteLine("3 - View balance.");

            Console.Write("Choice: ");
            int choice = int.Parse(Console.ReadLine()?? "0");


            switch (choice)
            {
                case 1:
                    Computation_Functions.Deposit(selectedPerson); // This will call deposit function for a selected person.
                    break;
            }
        }


        
        public static void WriteToFile(List<Person> newClients)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            // Ensure the Data folder exists
            var folderPath = Path.Combine(Environment.CurrentDirectory, "Data");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var filePath = Path.Combine(folderPath, "people.json");

            // Read existing data if the file exists
            List<Person> people = new List<Person>();
            if (File.Exists(filePath))
            {
                var existingJson = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    people = JsonSerializer.Deserialize<List<Person>>(existingJson, options) ?? new List<Person>();
                }
            }

            // Add new people
            people.AddRange(newClients);

            // Write combined list back to the file
            var json = JsonSerializer.Serialize(people, options);
            File.WriteAllText(filePath, json);
        }

        public static void LoaderFiler(List<Person> Clients)
        {
            var folderPath = Path.Combine(Environment.CurrentDirectory, "Data");
            var filePath = Path.Combine(folderPath, "people.json");

            if (!File.Exists(filePath))
                return; // No file, nothing to load

            var existingJson = File.ReadAllText(filePath);
            if (string.IsNullOrWhiteSpace(existingJson))
                return;

            // Deserialize into a temporary list and add its contents to the passed-in list
            var loadedPeople = JsonSerializer.Deserialize<List<Person>>(existingJson) ?? new List<Person>();
            Clients.AddRange(loadedPeople);
        }

    }
}

