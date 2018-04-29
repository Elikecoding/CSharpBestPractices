using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstHelperLibrary;
using FirstHelperLibrary.Logic_Classes;

namespace DemoConsoleUITests
{
    [TestClass]
    public class DemeritPointsCalcTests
    {
        [TestMethod]
        public void DemeritPointsCalc_OverSpeedLimit_Fail()
        {
            //Arrange 
            var myPoints = CalculateDemeritPoints(40);

            //Act 
            var result = myPoints;

            //Assert
            Assert.AreEqual(300, result);
        }

        [TestMethod]
        public void DemeritPointsCalc_OutOfRange_Fail()
        {
            //Arrange 
            var myPoints = CalculateDemeritPoints(1500);

            //Act 
            var result = myPoints;

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void DemeritPointsCalc_WithinRange_Pass()
        {
            //Arrange 
            var myPoints = CalculateDemeritPoints(200);

            //Act 
            var result = myPoints;

            //Assert
            Assert.AreEqual(1, result);
        }

        //Create two new variables for the speed limit and max speed
        private const int speedLimit = 40;
        private const int maxSpeed = 300;

        //This is where the points are calculated
        private int CalculateDemeritPoints(int speed)
        {
            //Throw an exception if the speed is outside of my range
            if (speed < 0 || speed > maxSpeed)
            {
                throw new ArgumentOutOfRangeException();
            }

            //Under the speed limit so nothing needs to be returned
            if (speed <= speedLimit)
            {
                return 0;
            }
            //Over the speed limit so deduct points
            else
            {
                const int milePerDemeritPoint = 5;
                var demeritPoints = (speed / speedLimit) / milePerDemeritPoint;

                return demeritPoints;
            }
        }
    }
}
