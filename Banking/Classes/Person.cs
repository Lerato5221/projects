using System;

namespace Banking.Classes
{
    public class Person{

        public String FullName {set; get;}
        public String Occupation {set; get;}
        public string Gender {set; get;}
        public int AccountNumber {set; get;}
        public double Amount {set; get;}
        public int Pin {set; get;}
        public int Age {set; get;}

        // Paramatized constructor
        public Person(String fullname, String occupation, string gender,int account,double amount, int pin, int age)
        {
            this.FullName = fullname;
            this.Occupation = occupation;
            this.Gender = gender;
            this.AccountNumber = account;
            this.Amount = amount;
            this.Pin = pin;
            this.Age = age;
        }
    }



}