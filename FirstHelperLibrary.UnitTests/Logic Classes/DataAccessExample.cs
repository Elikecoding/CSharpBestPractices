using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHelperLibrary.UnitTests.Logic_Classes
{
    public static class DataAccessExample
    {
        public static string ExampleLoadTextFile(string file)
        {
            if (file.Length < 10)
            {
               throw new ArgumentException("The file name was too short" , "file");
            }
            return "File was correctly loaded";
        }
    }
}
