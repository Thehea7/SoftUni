using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Bear bear = new("Ivan");
            Gorilla gorilla = new("KingKong");
            Mammal mamam = new("Milkdrinker");
            Snake snake = new("Nazdjini");
            Lizard lizard = new("Miglen");
            Reptile reptile = new("Kiro");
            Animal animal = new("Compliance");
            Console.WriteLine(snake.Name);
            Console.WriteLine(animal.GetType());
        }
    }
}