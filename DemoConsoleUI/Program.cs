using FirstHelperLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsoleUI
{
    class Program
    {
        //Create a list of people
        private static List<Person> people = new List<Person>();
        static void Main(string[] args)
        {
            /*NEW USER TEMPLATE 
             Person newUser = new Person();

             newUser.firstName = "TIMMYYY";
             newUser.lastName = "TURRRNEER";
             newUser.age = 99;
             newUser.email = "suckmydick@hotmail.com";
             newUser.balance = 110; */


            //Calling my sample data method from outside the static void main method because EACH METHOD SHOULD ONLY HAVE ONE FUNCTION
            SetUpSampleData();

            //Calling my greet function
            GreetAllPeople();

            //Get my string builder
            //StringBuilderTest();

            //Read Out my people
            Console.ReadLine();
        }
        /* //////STRING CONCATINATION///////

         string test = "Hello" + person.firstName + "" + person.lastName + "!";
     string betterTest = $"Hello {person.firstName} {person.lastName} !"; */

        //Test for my string builder
        private static void StringBuilderTest()
        {
            string s = "";
            StringBuilder Ns = new StringBuilder();

            Console.WriteLine(DateTime.Now.ToLongDateString());

            for (int i = 0; i < 100000; i++)
            {
                Ns.Append("Hi ");
            }

            Ns.ToString();
            Console.WriteLine(DateTime.Now.ToLongDateString());

        }

        //Add a list of people to the the Person Class
        private static void SetUpSampleData()
        {
            people.Add(new Person { firstName = "Jack", lastName = "Sawyer", email = "Fict@hotmail.com", age = 25, balance = 100 });
            people.Add(new Person { firstName = "Nick", lastName = "Shelby", email = "Fict1@hotmail.com", age = 35, balance = 300 });
            people.Add(new Person { firstName = "Joe", lastName = "Jones", email = "Fict2@hotmail.com", age = 47, balance = 450 });
            people.Add(new Person { firstName = "Harry", lastName = "Doe", email = "Fict3@hotmail.com", age = 16, balance = 500 });
            people.Add(new Person { firstName = "Tim", lastName = "Butcher", email = "Fict4@hotmail.com", age = 28, balance = 900 });
        }

        //Method to greet all my customers 
        private static void GreetAllPeople()
        {
            //Loop through a list of people and say hello
            foreach (var person in people)
            {
                //Curly braces are not need for if/else/elseif statements because the line below is automatically attacthed to the statment
                if (person.firstName != null)
                {
                    Console.WriteLine($"Hello {person.firstName} {person.lastName}");
                }
                else
                {
                    Console.WriteLine("I've got no friends");
                }
            }
        }
    }
}
