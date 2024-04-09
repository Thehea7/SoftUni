using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            if (number.All(char.IsNumber))
            {
                if (number.Length == 7)
                {
                    return $"Dialing... {number}";
                }
            }
            else
            {
                throw new ArgumentException("Invalid number!");
            }
            return default;
        }
    }
}
