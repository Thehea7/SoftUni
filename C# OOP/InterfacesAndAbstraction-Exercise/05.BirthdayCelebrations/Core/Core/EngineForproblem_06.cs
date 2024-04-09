using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.BirthdayCelebrations.Models;
using _05.BirthdayCelebrations.Models.Interfaces;

namespace _05.BirthdayCelebrations.Core.Core
{
    internal class EngineForproblem_06 : IEngine
    {
        public void Run()
        {
            List<IBuyer> people = new List<IBuyer>();
            int entries = int.Parse(Console.ReadLine());

            for (int i = 0; i < entries; i++)
            {
                
                string[] arguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string id = arguments[2];
                string name = arguments[0];
                string birthDay;
                if (id.All(char.IsNumber))
                {
                    birthDay = arguments[3];
                    int age = int.Parse(arguments[1]);
                    people.Add(new Citizen(name, id));
                }
                else
                {
                    people.Add(new Rebel(name, id));
                }
            }
            
            int totalFood = 0;
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string name = command;
                
                people.Where(x => x.Name == name).ToList().ForEach(x => x.BuyFood());
            }

            people.ForEach(x => totalFood+= x.Food);
            Console.WriteLine(totalFood);
        }
    }
}
