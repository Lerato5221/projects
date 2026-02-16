using System;

namespace Banking.Classes
{
    class Person{

        private String FullName;
        private String Occupation;
        private char Gender;
        int AccountNumber;
        int Pin;
        int Age;

        // Paramatized constructor
        Person(String fullname, String Occupation, char Gender, int pin, int age)
        {
            this.FullName = fullname;
            this.Occupation = Occupation;
            this.Gender = Gender;
            this.Pin = pin;
            this.Age = age;
        }
    }



}