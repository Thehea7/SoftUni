﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()
        {


            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                try
                {
                    var person = new Person(cmdArgs[0],
                        cmdArgs[1],
                        int.Parse(cmdArgs[2]),
                        decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            
            
            persons.ForEach(p => Console.WriteLine(p.ToString()));


        }
    }
}
