using System;
using System.Collections.Generic;
using _09.ExplicitInterfaces.Core.Interfaces;
using _09.ExplicitInterfaces.Models;
using _09.ExplicitInterfaces.Models.Interfaces;

namespace _09.ExplicitInterfaces.Core
{
    public class Engine :IEngine
    {
        public void Run()
        {

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();
                IResident citizenResident = new Citizen(arguments[0], arguments[1], int.Parse(arguments[2]));
                IPerson citizenPerson = new Citizen(arguments[0], arguments[1], int.Parse(arguments[2]));
                Console.WriteLine(citizenPerson.GetName());
                Console.WriteLine(citizenResident.GetName());

            }

            



        }
    }
}
