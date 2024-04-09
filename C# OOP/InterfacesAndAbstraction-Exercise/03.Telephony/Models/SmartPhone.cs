using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephony
{
    public  class SmartPhone : ICallable, IBrowse
    {
        public string Call(string number)
        {
            if (number.All(char.IsNumber))
            {
                if (number.Length == 10)
                {
                    return $"Calling... {number}";
                }
            }
            else
            {
                throw new ArgumentException("Invalid number!");
            }

            return default;
        }


        public string Browse(string url)
        {
            char a = url.FirstOrDefault(x => char.IsNumber(x));
            
            if (url.Any(char.IsNumber))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }
    }
}
