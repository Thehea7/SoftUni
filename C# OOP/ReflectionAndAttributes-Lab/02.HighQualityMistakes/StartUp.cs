using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class StartUp
    {

        static void Main()
        {
            Spy spy = new Spy();

            string result = spy.StealFieldInfo("Stealer.Hacker", "username", "password");
            Console.WriteLine(result);

            result = spy.AnalyzeAccessModifiers("Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}
