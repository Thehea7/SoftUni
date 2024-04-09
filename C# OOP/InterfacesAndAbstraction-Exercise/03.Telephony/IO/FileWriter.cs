using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.Telephony.IO.Interfaces;

namespace _03.Telephony.IO
{
    public class FileWriter : IWriter
    {
        private string path = "../../../result.txt";
        public void WriteLine(string line)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(line);
            }
        }
    }
}
