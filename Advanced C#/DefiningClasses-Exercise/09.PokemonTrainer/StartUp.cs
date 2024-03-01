using System.Threading.Channels;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, Trainer> trainers = new();


            string command;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainersName = arguments[0];
                string pokemonsName = arguments[1];
                string element = arguments[2];
                int helth = int.Parse(arguments[3]);

                Pokemon pokemon = new Pokemon(pokemonsName, element, helth);
                if (!trainers.ContainsKey(trainersName))
                {
                    trainers.Add(trainersName, new Trainer(trainersName, new List<Pokemon>()));
                }
                trainers[trainersName].Pokemons.Add(pokemon);


            }

            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();
                foreach (var (name, trainer) in trainers)
                {
                    trainer.ExecuteCommand(command);
                }
            }

            foreach (var (name, trainer) in trainers.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine(trainer);
            }

            

            

        }
    }
}