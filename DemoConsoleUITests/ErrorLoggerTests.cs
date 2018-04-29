using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoConsoleUITests
{
    [TestClass]
    public class ErrorLoggerTests
    {
        [TestMethod]
        public void TestErrorLogger_NullError_Fail()
        {
            //Arrange 
            var myLog = lastError;
            Log(myLog);

            //Act
            var result = myLog;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestErrorLogger_NotNullError_Pass()
        {
            //Arrange 
            var myLog = "This is an error";
            Log(myLog);

            //Act
            var result = myLog;

            //Assert
            Assert.IsNotNull(result);
        }

        //Create a string property for my error
        public string lastError { get; set; }

        //Event handler for my errors 
        public event EventHandler<Guid> ErrorLogged;

        public void Log(string error)
        {
            if (String.IsNullOrWhiteSpace(error))
            {
                //If my string is null tell me
                throw new ArgumentNullException();
            }
            else
            {
                //Store my error in a log 
                lastError = error;
                ErrorLogged?.Invoke(this, Guid.NewGuid());
            }
        }


    }
}
