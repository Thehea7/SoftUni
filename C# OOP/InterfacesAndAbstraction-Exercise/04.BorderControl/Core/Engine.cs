using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using _04.BorderControl.Core.Interfaces;
using _04.BorderControl.Models;

namespace _04.BorderControl.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            List<Entity> entities = new List<Entity>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();
                string name = arguments[0];
                string id;
                if (arguments.Length == 2)
                {
                    id = arguments[1];
                }
                else
                {
                    id = arguments[2];
                }

                entities.Add(new Citizen(name, id));
            }

            string key = Console.ReadLine();
            entities.Where(x => x.Id.EndsWith(key)).ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}
