using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHelperLibrary.Logic_Classes
{
    //This is a class to deal with maths for me
    public static class Calculator
    {
        //Adding
        public static int Add(int a, int b)
        {
            if (a+b > int.MaxValue || a+b < int.MinValue)
            {
                throw new Exception("The number you are trying to calculate is out my range");
            }
            return a + b;
        }

        //Subtracting
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        //Multiplication
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        //Division
        public static int Division(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                return 0;
            }
        }

        public static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public static IEnumerable<int> GetOddNumbers(int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                if (i % 2 != 0)
                {
                    yield return i;
                }
            }
        }
    }
}
