using System.Data.Common;
using System.Net;

namespace _01.Ranking
{
    class Contest
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public int Points { get; set; } 

        public Contest(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public Contest(string name, int points)
        {
            Name = name;
           
            Points = points;
        }

        public override string ToString()
        {
            return $"{Name} -> {Points}";
        }
    }

    class Student
    {
        public Student(string name)
        {
            Name = name;
            ListOfContests = new List<Contest>();
        }

        public string Name { get; set; }
        public List<Contest> ListOfContests { get; set; }

        public int TotalPoints { get; set; }

        public void GetTotalPoints()
        {
            foreach (var contest in ListOfContests)
            {
                TotalPoints += contest.Points;
            }
        }

        public override string ToString()
        {
            var orderedList = ListOfContests.OrderByDescending(x => x.Points).ToList();
            return $"{Name}\n#  {string.Join("\n#  ", orderedList)}";
        }
    }

    internal class Program
    {
       
        static void Main()
        {
            Dictionary<string, Contest> credentialsMap = new Dictionary<string, Contest>();

            CollectCredentials(credentialsMap);

            Dictionary<string, Student> resultsMap = new Dictionary<string, Student>();

            ReceiveSubmissions(credentialsMap, resultsMap);

            var orderedByName = resultsMap.OrderBy(x => x.Key);

           

            var maxPointsMax = orderedByName.Max(x => x.Value.TotalPoints);
            Student student = orderedByName.FirstOrDefault(x => x.Value.TotalPoints == maxPointsMax).Value;
            Console.WriteLine($"Best candidate is {student.Name} with total {student.TotalPoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var pair in orderedByName)
            {
                Console.WriteLine(pair.Value);
            }
        }

        private static void ReceiveSubmissions(Dictionary<string, Contest> credentialsMap, Dictionary<string, Student> resultsMap)
        {
            string command;
            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] arguments = command.Split("=>");

                string contestName = arguments[0];
                string contestPass = arguments[1];
                string studentName = arguments[2];
                int points = int.Parse(arguments[3]);

                if (credentialsMap.ContainsKey(contestName))
                {
                    if (credentialsMap[contestName].Password == contestPass)
                    {
                        if (!resultsMap.ContainsKey(studentName))
                        {
                            resultsMap.Add(studentName, new Student(studentName));
                        }

                        if (!resultsMap[studentName].ListOfContests.Exists(x => x.Name == contestName))
                        {
                            resultsMap[studentName].ListOfContests.Add(new Contest(contestName, points));
                        }
                        else
                        {
                            Contest contest = resultsMap[studentName].ListOfContests.Find(x => x.Name == contestName);
                            if (contest.Points < points)
                            {
                                int i = resultsMap[studentName].ListOfContests.FindIndex(x => x.Name == contestName);
                                resultsMap[studentName].ListOfContests[i].Points = points;
                            }
                        }
                    }
                }
            }
            foreach (var student in resultsMap)
            {
                student.Value.GetTotalPoints();
            }
        }

        private static void CollectCredentials(Dictionary<string, Contest> credentialsMap)
        {
            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] arguments = input.Split(":");
                string name = arguments[0];
                string password = arguments[1];

                credentialsMap.Add(name, new Contest(name, password));
            }
        }
    }
}