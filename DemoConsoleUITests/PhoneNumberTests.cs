using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoConsoleUITests
{
    [TestClass]
    public class PhoneNumberTests
    {
        [TestMethod]
        public void TestNullPhoneNumber_Fail()
        {
            //Arrange 
            var myNumber = PhoneNumber.Parse("");

            //Act 
            var result = myNumber;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestNotNullPhoneNumber_Pass()
        {
            //Arrange 
            var myNumber = PhoneNumber.Parse("7777777777");

            //Act 
            var result = myNumber;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestTooShortPhoneNumber_Fail()
        {
            //Arrange 
            var myNumber = PhoneNumber.Parse("777777777");

            //Act 
            var result = myNumber;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestTooLongPhoneNumber_Fail()
        {
            //Arrange 
            var myNumber = PhoneNumber.Parse("77777777777");

            //Act 
            var result = myNumber;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestSpecCharPhoneNumber_Fail()
        {
            //Arrange 
            var myNumber = PhoneNumber.Parse("777777777$");

            //Act 
            var result = myNumber;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestWhiteSpacePhoneNumber_Fail()
        {
            //Arrange 
            var myNumber = PhoneNumber.Parse("77777 7777");

            //Act 
            var result = myNumber;

            //Assert
            Assert.IsNotNull(result);
        }

        public class PhoneNumber
        {
            //Get my digits
            public string Area { get; }
            public string Major { get; }
            public string Minor { get; }

            //Arrange them into a phone number
            private PhoneNumber(string area, string major, string minor)
            {
                Area = area;
                Major = major;
                Minor = minor;
            }

            //Parse my digits together 
            public static PhoneNumber Parse(string number)
            {
                if (String.IsNullOrEmpty(number))
                {
                    throw new ArgumentException("Phone Number cannot be blank");
                }
                else if (number.Length != 10)
                {
                    throw new ArgumentException("Please check the amount of digits in your phone number");
                }
                else if (number.Contains("A") || number.Contains("B") || number.Contains("C") || number.Contains("D") || number.Contains("E") ||
                         number.Contains("F") || number.Contains("G") || number.Contains("H") || number.Contains("I") || number.Contains("J") ||
                         number.Contains("K") || number.Contains("L") || number.Contains("M") || number.Contains("N") || number.Contains("O") ||
                         number.Contains("P") || number.Contains("Q") || number.Contains("R") || number.Contains("S") || number.Contains("T") ||
                         number.Contains("U") || number.Contains("V") || number.Contains("W") || number.Contains("Y") || number.Contains("X") ||
                         number.Contains("Z") || number.Contains("/") || number.Contains("*") || number.Contains("-") || number.Contains("+") ||
                         number.Contains("=") || number.Contains("-") || number.Contains("_") || number.Contains(")") || number.Contains("&") ||
                         number.Contains("^") || number.Contains("%") || number.Contains("$") || number.Contains("£") || number.Contains("!") ||
                         number.Contains(";") || number.Contains(":") || number.Contains("'") || number.Contains("@") || number.Contains("[") ||
                         number.Contains("]") || number.Contains("{") || number.Contains("}") || number.Contains(" "))
                {
                    throw new ArgumentException("Phone number cannot have any whites spaces and should only contain numbers");
                }

                var area = number.Substring(0, 3);
                var major = number.Substring(3, 3);
                var minor = number.Substring(6);

                return new PhoneNumber(area, major, minor);

            }

            //Return my new number
            public override string ToString()
            {
                return String.Format($"({Area})-{Major}-{Minor}");
            }
        }
    }
}
