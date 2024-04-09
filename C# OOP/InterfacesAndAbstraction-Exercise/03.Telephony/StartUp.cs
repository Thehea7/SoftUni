using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Telephony.Core;
using _03.Telephony.Core.Interfaces;
using _03.Telephony.IO;

namespace _03.Telephony
{
    public class StartUp
    {
        static void Main()
        {
            ConsoleReader reader = new ConsoleReader();
            ConsoleWriter writer = new ConsoleWriter();
            FileWriter fileWriter = new FileWriter();

            IEngine engine = new Engine(reader, fileWriter);
            engine.Run();
        }
    }
}
