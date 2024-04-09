using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephony
{
    public interface ICallable
    {
        public string Call(string number);
    }
}
