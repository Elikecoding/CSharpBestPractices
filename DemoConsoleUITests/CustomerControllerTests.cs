using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstHelperLibrary;
using FirstHelperLibrary.Logic_Classes;

namespace DemoConsoleUITests
{
    [TestClass]
    public class CustomerControllerTests
    {
        [TestMethod]
        public void TestGetCustomerById_Null_Fail()
        {
            //Arrange 
            var myCustomer = GetCustomerById(0);

            //Act
            var result = myCustomer;

            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestGetCustomerById_NotNull_Pass()
        {
            //Arrange 
            var myCustomer = GetCustomerById(1);

            //Act
            var result = myCustomer;

            //Assert
            Assert.IsNotNull(result);
        }

        public ActionResult GetCustomerById(int id)
        {
            //Condition if my custoemr is not found 
            if (id == 0)
            {
                return new NotFound();
            }
            //Condition if my customer is found 
            else
            {
                return new OK();
            }

        }

        //Default Action Result Class
        public class ActionResult
        {
        }

        //Action Result if not found
        public class NotFound : ActionResult
        {
        }

        //Action Result if found
        public class OK : ActionResult
        {
        }

    }
}
