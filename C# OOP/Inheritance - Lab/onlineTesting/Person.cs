﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineTesting
{
    public class Person
    {
        public string FirstName  { get; set; }
        public string LastName  { get; set; }
        public string Address  { get; set; }

        public Person Father { get; set; }

        public void Sleep()
        {
            Console.WriteLine("Zzzzzz");
        }

    }
}
