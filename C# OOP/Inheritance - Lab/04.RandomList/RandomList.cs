using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            string result = string.Empty;
            Random random = new Random();
            if (Count > 0)
            {
                int index = random.Next(Count - 1);
                result = this[index];
                RemoveAt(index);
            }
            
            return result;
        }
    }
}
