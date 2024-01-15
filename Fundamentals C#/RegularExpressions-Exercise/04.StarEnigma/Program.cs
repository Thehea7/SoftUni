using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    internal class Program
    {
        static void Main()
        {
            Regex decyption = new Regex(@"S|s|T|t|A|a|R|r");
            Regex regex =
                new Regex(
                    @"@(?'planetName'[a-zA-Z]+)[^\@\-\!\:\>]*:(?'population'\d+)[^\@\-\!\:\>]*\!(?'atackType'A|D)\![^\@\-\!\:\>]*->(?'soldierCount'\d+)[^\@\-\!\:\>]*");
            int inputCount = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPLanets = new List<string>();


            for (int i = 0; i < inputCount; i++)
            {
                string input = Console.ReadLine();
                int key = decyption.Matches(input).Count;
                
                StringBuilder decryptedInput = new StringBuilder();
                foreach (var ch in input)
                {
                    decryptedInput.Append((char)(ch - key));
                }

                if (regex.IsMatch(decryptedInput.ToString()))
                {
                    
                    Match match = regex.Match(decryptedInput.ToString());
                    
                    if (match.Groups["atackType"].Value == "A")
                    {
                        attackedPlanets.Add(match.Groups["planetName"].Value);
                    }
                    else
                    {
                        destroyedPLanets.Add(match.Groups["planetName"].Value);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var attackedPlanet in attackedPlanets.OrderBy(x => x))
            {
                Console.Write($"-> {attackedPlanet}\n");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPLanets.Count}");
            foreach (var destroyedPLanet in destroyedPLanets.OrderBy(x => x))
            {
                Console.Write($"-> {destroyedPLanet}\n");
            }
        }
    }
}