using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FirstHelperLibrary;
using FirstHelperLibrary.UnitTests.Logic_Classes;
using System.IO;

namespace FirstHelperLibrary.XunitTest
{
    public class DataAccessExampleTests
    {

        [Fact]
        public void TestDataAccessExample()
        {
            //Arrange
            string actual = DataAccessExample.ExampleLoadTextFile("This is a valid file name");

            //Act

            //Assert
            Assert.True(actual.Length > 0);
        }

        [Fact]
        public void TestDataAccessExample_FileName_Fail()
        {
            //Arrange

            //Act

            //Assert
            Assert.Throws<ArgumentException>("file1", () => DataAccessExample.ExampleLoadTextFile(""));
        }
    }
}
