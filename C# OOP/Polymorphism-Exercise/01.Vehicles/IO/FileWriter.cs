using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _01.Vehicles.IO.Interfaces;

namespace _01.Vehicles.IO
{
    public class FileWriter :IWriter
    {
        private const string filePath = "../../../result.txt";

          

        public void WriteLine(string st)
        {
            using StreamWriter writer = new(filePath, true);
            writer.WriteLine(st);
        }

        public void Write(string st)
        {
            using StreamWriter writer = new(filePath, true);
            writer.Write(st);
        }
    }
}
