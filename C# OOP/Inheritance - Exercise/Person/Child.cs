﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Person
{
    public class Child : Person
    {

        
        

        public Child(string name, int age)
            : base(name, age)
        {
           
        }

        //public override int Age
        //{
        //    get => base.Age;
        //    set
        //    {
        //        if (value <= 15)
        //        {
        //            base.Age = value;
        //        }
        //    }
        //}

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
