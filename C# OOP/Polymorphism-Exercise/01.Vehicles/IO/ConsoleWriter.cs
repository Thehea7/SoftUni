using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Vehicles.IO.Interfaces;

namespace _01.Vehicles.IO
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string st)
        {
            Console.WriteLine(st);
        }

        public void Write(string st)
        {
            Console.Write(st);
        }
    }
}
