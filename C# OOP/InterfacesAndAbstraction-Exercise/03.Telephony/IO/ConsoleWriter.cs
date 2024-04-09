using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Telephony.IO.Interfaces;

namespace _03.Telephony.IO
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
