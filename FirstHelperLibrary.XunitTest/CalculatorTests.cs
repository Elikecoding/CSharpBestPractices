using FirstHelperLibrary.Logic_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FirstHelperLibrary.XunitTest
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 1, 3)]
        [InlineData(1, 1, 2)]
        public void TestAddMethod(int x, int y, int expected)
        {
            //Arrange 

            //Act
            var actual = Calculator.Add(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 1, 0)]
        [InlineData(2, 1, 1)]
        public void TestSubtractMethod(int x, int y, int expected)
        {
            //Arrange 

            //Act
            var actual = Calculator.Subtract(x, y);

            //Assert
            Assert.Equal(expected, actual);
        } 

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(2, 0, 0)]
        [InlineData(2, 1, 2)]
        public void TestDivideMethod(int x, int y, int expected)
        {
            //Arrange 


            //Act
            var actual = Calculator.Division(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 3)]
        [InlineData(2, 2, 4)]
        public void TestMultiplyMethod(int x, int y, int expected)
        {
            //Arrange 

            //Act
            var actual = Calculator.Multiply(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
