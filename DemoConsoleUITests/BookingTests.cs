using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstHelperLibrary;
using FirstHelperLibrary.Logic_Classes;

namespace DemoConsoleUITests
{
    [TestClass]
    public class DemeritPointsCalculatorTests
    {
        [TestMethod]
        public void TestCanBeCancelledBy_IsAdmin_Fail()
        {
            //Arrange
            var myBooking = new BookingClass();

            //Act
            var result = myBooking.CanBeCancelledBy(new Person { IsAdmin = true });

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCanBeCancelledBy_IsAdmin_Pass()
        {
            //Arrange 
            var myBooking = new BookingClass();

            //Act
            var result = myBooking.CanBeCancelledBy(new Person { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCanBeMadeBy_Person_Fail()
        {
            //Arrange 
            var myPerson = new Person();
            var myBooking = new BookingClass { MadeBy = myPerson };


            //Act
            var result = myBooking.CanBeMadeBy(myPerson);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCanBeMadeBy_Person_Pass()
        {
            //Arrange 
            var myPerson = new Person();
            var myBooking = new BookingClass { MadeBy = myPerson };


            //Act
            var result = myBooking.CanBeMadeBy(myPerson);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
