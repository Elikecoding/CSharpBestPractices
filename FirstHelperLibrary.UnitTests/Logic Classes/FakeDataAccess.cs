using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHelperLibrary.UnitTests.Logic_Classes
{
    public static class FakeDataAccess
    {
        //Create my text file 
        private static string personTxtFile = "Person.txt";

        //Add people to my text file
        public static void AddNewPerson(Person person)
        {
            //My list of people
            List<Person> peopleList = GetAllPeople();

            AddPersonToPeopleList(peopleList, person);

            List<string> myLines = ConvertModelToCsv(peopleList);

            //Now put it into a text file for me 
            File.WriteAllLines(personTxtFile, myLines);

        }

        //Add Person to my List
        public static void AddPersonToPeopleList(List<Person> peopleList, Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                throw new ArgumentException("Please check if one of your parameters is null", "FirstName");
            }
            else if (string.IsNullOrWhiteSpace(person.LastName))
            {
                throw new ArgumentException("Please check if one of your parameters is null", "LastName");
            }
            else if (string.IsNullOrWhiteSpace(person.Email))
            {
                throw new ArgumentException("Please check if one of your parameters is null", "Email");
            }
            peopleList.Add(person);
        }

        //Convert my list of people to list of string
        public static List<string> ConvertModelToCsv(List<Person> peopleList)
        {
            //My string list
            List<string> output = new List<string>();

            if (peopleList.Count == 0)
            {
                throw new Exception("The people list cannot be empty");
            }
            else if (peopleList.Count > 1)
            {
                //Bit of string concat
                foreach (Person user in peopleList)
                {
                    output.Add($"{user.Id},{user.FirstName},{user.LastName},{user.Email},{user.Balance}");
                }
            }
            return output;
        }

        //Get my peoples
        private static List<Person> GetAllPeople()
        {
            //New list for the output
            List<Person> output = new List<Person>();

            //String Array for my lines
            string[] content = File.ReadAllLines(personTxtFile);

            //Split up my lines
            foreach (string line in content)
            {
                string[] data = line.Split(',');
                output.Add(new Person { FirstName = data[0], LastName = data[1], Email = data[2]});

            }
            //Give me my list back
            return output;
        }
    }
}
