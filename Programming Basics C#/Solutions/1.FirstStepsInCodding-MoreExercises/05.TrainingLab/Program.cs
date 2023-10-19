using System;

namespace _05.TrainingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double lmeters = double.Parse(Console.ReadLine());
            double wmeter = double.Parse(Console.ReadLine());
            //calculations
            wmeter = wmeter - 1;// махаме 1м коридор
            double  deskPerRow = wmeter / 0.7;// намираме колко бура могат да се суберат на редица, като по долу ползваме Матх.Флоор функцията за да видим колко точно цели се събират без да ни интересува остатъка.
            double rowsPerL = lmeters / 1.2;//намираме колко редици се побират по дължината в стаята, като отново закръгляме на долу.
            double totaldesks = Math.Floor(deskPerRow) * Math.Floor(rowsPerL) - 3;// намираме колко са вси4ки бура и махаме 3 които по условие са заети от врата и катедра
            //Print
            Console.WriteLine(totaldesks);

            Console.WriteLine(42 % 7); 
        }
    }
}
