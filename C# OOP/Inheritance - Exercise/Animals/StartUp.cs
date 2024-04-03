using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            
            string command;

            while ((command = Console.ReadLine()) != "Beast!")
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                try
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    switch (command)
                    {
                        case "Dog":
                            Dog dog = new Dog(name, age, input[2]);
                            Console.WriteLine(dog);
                            break;
                        case "Cat":
                                Cat cat = new Cat(name, age, input[2]);
                                Console.WriteLine(cat);
                            break;
                        case "Frog":
                            Frog frog = new Frog(name, age, input[2]);
                            Console.WriteLine(frog);
                            break;
                        case "Tomcat":
                            Tomcat aTomcat = new Tomcat(name, age);
                            Console.WriteLine(aTomcat);
                            break;
                        case "Kitten":
                            Kitten kitty = new Kitten(name, age);
                            Console.WriteLine(kitty);
                            break;
                    }
                }
                catch (ArgumentException error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }
    }
}
