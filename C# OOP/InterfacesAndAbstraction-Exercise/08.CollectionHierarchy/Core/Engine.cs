
using _08.CollectionHierarchy.Core.Interfaces;
using _08.CollectionHierarchy.Models;
using _08.CollectionHierarchy.Models.Interfaces;

namespace _08.CollectionHierarchy.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();
            List<IAdd> collections = new List<IAdd>() { addCollection, addRemoveCollection, myList };

            string[] input = Console.ReadLine().Split(" ");

            int deletionCount = int.Parse(Console.ReadLine());
            if (input.Length > 0)
            {

                foreach (var collection in collections)
                {

                    foreach (var inputItem in input)
                    {

                        Console.Write($"{collection.Add(inputItem)} ");
                    }

                    Console.WriteLine();
                }

                List<IRemove> removeCollections = new List<IRemove>() { addRemoveCollection, myList };

                foreach (var collection in removeCollections)
                {
                    for (int i = 0; i < deletionCount; i++)
                    {

                        Console.Write($"{collection.Remove()} ");

                    }

                    Console.WriteLine();
                }
            }

        }
    }
}
