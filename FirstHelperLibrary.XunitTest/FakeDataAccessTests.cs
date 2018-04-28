using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstHelperLibrary;
using FirstHelperLibrary.UnitTests.Logic_Classes;
using Xunit;

namespace FirstHelperLibrary.XunitTest
{
    public class FakeDataAccessTests
    {
        [Fact]
        public void AddPersonToPeopleList_Pass()
        {
            //Arrange
            Person newPerson = new Person { FirstName = "Test", LastName = "Person", Email = "Test.Person@Outlook.com", Balance = 150 };
            List<Person> peopleList = new List<Person>();

            //Act
            FakeDataAccess.AddPersonToPeopleList(peopleList, newPerson);

            //Assert
            Assert.True(peopleList.Count == 1);
            Assert.Contains<Person>(newPerson, peopleList);
        }

        [Theory]
        [InlineData("Test", "", "Test.Person@example.com", "LastName")]
        [InlineData("", "Person", "Test.Person@example.com", "FirstName")]
        [InlineData("Test", "Person", "", "Email")]
        public void AddPersonToPeopleList_ThrowException_Pass(string firstName, string lastName, string email, string param)
        {
            //Arrange
            Person newPerson = new Person { FirstName = firstName, LastName = lastName, Email = email };
            List<Person> peopleList = new List<Person>();

            //Act

            //Assert
            Assert.Throws<ArgumentException>(param, () => FakeDataAccess.AddPersonToPeopleList(peopleList, newPerson));
        }

        [Fact]
        public void ConvertModelToCsv_Pass()
        {
            //Arrange
            List<Person> peopleList = new List<Person>();
            peopleList.Add(new Person { FirstName = "Test", LastName = "Person", Email = "Test.Person@Outlook.com", Balance = 150 });
            //Act
            var convList =  FakeDataAccess.ConvertModelToCsv(peopleList);

            //Assert
            Assert.NotNull(peopleList);

        }

        [Fact]
        public void ConvertModelToCsv_NullList_Fail()
        {
            //Arrange
            List<Person> peopleList = new List<Person>();

            //Act
            var convList = FakeDataAccess.ConvertModelToCsv(peopleList);

            //Assert
            Assert.NotNull(convList);
        }
    }
}
