using System;

namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());
            //

            int examTime = examHour * 60 + examMinutes;
            int arrivaltime = arrivalHour * 60 + arrivalMinutes;
            int difference = examTime - arrivaltime;

            if (difference >= 0 && difference <= 30 )
            {
                
                Console.WriteLine("On time");
                if (difference != 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                
            }
            else if (difference >30)
            {
                Console.WriteLine("Early");
                if(difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else if(difference % 60 > 9)
                { Console.WriteLine($"{difference / 60}:{difference % 60} hours before the start"); }
                else { Console.WriteLine($"{difference / 60}:0{difference % 60} hours before the start"); }

            }
            else
            {
                difference = Math.Abs(difference);
                Console.WriteLine("Late");
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else if (difference % 60 > 9)
                { Console.WriteLine($"{difference / 60}:{difference % 60} hours after the start"); }
                else { Console.WriteLine($"{difference / 60}:0{difference % 60} hours after the start"); }
            }
        }
    }
}
