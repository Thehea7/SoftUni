using System.Xml.Linq;

namespace _2._Judge
{
    class Peron
    {
        public Peron(string name, int points)
        {
            Name = name;
            Points = points;
            Courses = new List<Course>();
        }
        public int TotalPoints { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }

        public List<Course> Courses { get; set; }

        public void GetTotalPoints()
        {
            foreach (var course in Courses)
            {
                TotalPoints += course.Points;
            }
        }

        public override string ToString()
        {
            return $"{Name} <::> {Points}";
        }
    }

    class Course
    {
        public string Name { get; set; }
        public List<Peron> PeopleList { get; set; }

        public int Points { get; set; }

        public Course(string name, int points)
        {
            Name = name;
            PeopleList = new List<Peron>();
            Points = points;
        }

        public void OrderPeopleList()
        {
            PeopleList = PeopleList.OrderByDescending(x => x.Points).ThenBy(x => x.Name).ToList();
        }

    }
    internal class Program
    {
        static void Main()
        {

            Dictionary<string, Peron> peopleMap = new Dictionary<string, Peron>();
            Dictionary<string, Course> coursesMap = new Dictionary<string, Course>();

            FillDictionaries(peopleMap, coursesMap);

            foreach (var course in coursesMap)
            {
                course.Value.OrderPeopleList();
            }

            foreach (var peron in peopleMap)
            {
                peron.Value.GetTotalPoints();
            }

            var orderedPeopleMap = peopleMap.OrderByDescending(x => x.Value.TotalPoints).ThenBy(x => x.Key);
           //Print Output
            foreach (var course in coursesMap)
            {
                Console.WriteLine($"{course.Key}: {course.Value.PeopleList.Count} participants");
                for (int i = 0; i < course.Value.PeopleList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {course.Value.PeopleList[i]}");
                }
            }

            Console.WriteLine("Individual standings:");
            int k = 1;
            foreach (var pair in orderedPeopleMap)
            {
                Console.WriteLine($"{k}. {pair.Key} -> {pair.Value.TotalPoints}");
                k++;
            }
        }

        private static void FillDictionaries(Dictionary<string, Peron> peopleMap, Dictionary<string, Course> coursesMap)
        {
            // Read Input
            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] arguments = input.Split(" -> ");

                string name = arguments[0];
                string courseName = arguments[1];
                int coursePoints = int.Parse(arguments[2]);

                var person = new Peron(name, coursePoints);
                var course = new Course(courseName, coursePoints);

                //Fill people - below
                if (!peopleMap.ContainsKey(person.Name))
                {
                    peopleMap.Add(person.Name, person);
                }

                if (!peopleMap[name].Courses.Exists(x => x.Name == courseName))
                {
                    peopleMap[name].Courses.Add(course);
                }

                int indexc = peopleMap[name].Courses.FindIndex(x => x.Name == courseName);
                if (peopleMap[name].Courses[indexc].Points < coursePoints)
                {
                    peopleMap[name].Courses[indexc].Points = coursePoints;
                }

                // fill courses - below
                if (!coursesMap.ContainsKey(courseName))
                {
                    coursesMap.Add(courseName, course);
                }

                if (!coursesMap[courseName].PeopleList.Exists(x => x.Name == name))
                {
                    coursesMap[courseName].PeopleList.Add(person);
                }

                int index = coursesMap[courseName].PeopleList.FindIndex(x => x.Name == name);
                if (coursesMap[courseName].PeopleList[index].Points < coursePoints)
                {
                    coursesMap[courseName].PeopleList[index].Points = coursePoints;
                }


            }
        }
    }
}