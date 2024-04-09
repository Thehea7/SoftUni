using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08.CollectionHierarchy.Models.Interfaces;

namespace _08.CollectionHierarchy.Models
{
    public class AddCollection : IAdd
    {
        protected List<string> List { get; } = new();
        protected virtual int AddIndex => List.Count;

        public  int Add(string item)
        {
            int result = AddIndex;
            List.Insert(AddIndex, item);
            return result;
        }
    }
}
