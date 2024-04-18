using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorProblem
{
    [Author("Victor")]
    public class StartUp
    {
        [Author("George")]
        static void Main()
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
            
            // Use the same solution for problem 6
        }
    }
}
