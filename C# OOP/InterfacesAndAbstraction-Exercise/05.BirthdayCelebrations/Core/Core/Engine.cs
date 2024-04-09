

using _05.BirthdayCelebrations.Models;
using _05.BirthdayCelebrations.Models.Interfaces;

namespace _05.BirthdayCelebrations
{
    public class Engine : IEngine
    {
        public void Run()
        {
            List<IBorn> beings = new List<IBorn>();
            string commands;
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] arguments = commands.Split();
                string command = arguments[0];
                string name = arguments[1];
                string birthDay;
                if (command == "Pet")
                {
                    birthDay = arguments[2];
                    beings.Add(new Pet(name, birthDay));
                }
                else if(command == "Citizen")
                {
                    birthDay = arguments[4];
                    int age = int.Parse(arguments[2]);
                    string id = arguments[3];
                    beings.Add(new Citizen(name, id, age, birthDay));
                }

                
            }

            string key = Console.ReadLine();
            beings.Where(x => x.Birthday.EndsWith(key)).ToList().ForEach(x => Console.WriteLine(x.Birthday));

        }
    }
}
