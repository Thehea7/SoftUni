using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.StackOfStrings
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return Count == 0;
        }

        public void AddRange(IEnumerable<string> elements)
        {
            
            foreach (var element in elements)
            {
                Push(element);
            }
            
        }
    }
}
