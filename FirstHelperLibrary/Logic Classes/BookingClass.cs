﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHelperLibrary.Logic_Classes
{
    public class BookingClass
    {
        public Person MadeBy { get; set; }

        public bool CanBeCancelledBy(Person person)
        {
            return (person.IsAdmin || MadeBy == person);
        }

        public bool CanBeMadeBy(Person person)
        {
            return (person.IsAdmin || MadeBy == person);
        }
    }
}
