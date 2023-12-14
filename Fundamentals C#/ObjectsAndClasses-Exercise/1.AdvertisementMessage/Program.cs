using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace _1.AdvertisementMessage
{
  

    internal class Program
    {
        static void Main()
        {
            List<string> phrases = "Excellent product., Such a great product., I always use that product., Best product of its category., Exceptional product., I can't live without this product."
                .Split(", ")
                .ToList();
            List<string> events = "Now I feel good., I have succeeded with this product., Makes miracles. I am happy of the results!, I cannot believe but now I feel awesome., Try it yourself, I am very satisfied., I feel great!"
                .Split(", ")
                .ToList();
            List<string> authors = "Diana, Petya, Stella, Elena, Katya, Iva, Annie, Eva"
                .Split(", ")
                .ToList();
            List<string> cities = "Burgas, Sofia, Plovdiv, Varna, Ruse"
                .Split(", ")
                .ToList();
            

            int messagesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < messagesCount; i++)
            {
                Random random = new Random();
              
                string phrase = phrases[random.Next(phrases.Count)];
                
                string eventt = events[random.Next(events.Count)];

                string author = authors[random.Next(authors.Count)];

                string city = cities[random.Next(cities.Count)];

                Console.WriteLine($"{phrase} {eventt} {author} – {city}.");
            }

        }

    }

}