using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstHelperLibrary;
using FirstHelperLibrary.Logic_Classes;

namespace DemoConsoleUITests
{
    [TestClass]
    public class DateHelperTests
    {
        [TestMethod]
        public void TestDateHelper_NewYear_Fail()
        {
            //Arrange 
            var myDate = new DateTime(2018, 12, 31);
            var expectedDate = new DateTime(2017, 1, 1);
            var myHelper =  FirstOfNextMonth(myDate);

            //Act
            var result = myHelper;

            //Assert
            Assert.AreEqual(expectedDate, result);
        }

        [TestMethod]
        public void TestDateHelper_NewYear_Pass()
        {
            //Arrange 
            var myDate = new DateTime(2018, 12, 31);
            var expectedDate = new DateTime(2019, 1, 1);
            var myHelper = FirstOfNextMonth(myDate);

            //Act
            var result = myHelper;

            //Assert
            Assert.AreEqual(expectedDate, result);
        }

        [TestMethod]
        public void TestDateHelper_NewMonth_Fail()
        {
            //Arrange 
            var myDate = new DateTime(2018, 10, 31);
            var expectedDate = new DateTime(2018, 12, 1);
            var myHelper = FirstOfNextMonth(myDate);

            //Act
            var result = myHelper;

            //Assert
            Assert.AreEqual(expectedDate, result);
        }

        [TestMethod]
        public void TestDateHelper_NewMonth_Pass()
        {
            //Arrange 
            var myDate = new DateTime(2018, 10, 31);
            var expectedDate = new DateTime(2018, 11, 1);
            var myHelper = FirstOfNextMonth(myDate);

            //Act
            var result = myHelper;

            //Assert
            Assert.AreEqual(expectedDate, result);
        }

        //Ternary to return a new date time depending on the current date time
        public static DateTime FirstOfNextMonth(DateTime date)
        {
            return date.Month == 12 ? new DateTime(date.Year + 1, 1, 1) : new DateTime(date.Year, date.Month + 1, 1);
        }

    }
}
