using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHelperLibrary
{
    //This class will represent an instance of your person 
    public class Person
    {
        //This is the proper way to create public variables DO NOT USE public variables
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public decimal balance { get; set; }
    }
}
