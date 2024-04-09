using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08.CollectionHierarchy.Models.Interfaces;

namespace _08.CollectionHierarchy.Models
{
    public class AddRemoveCollection : AddCollection, IRemove
    {
        protected override int AddIndex => 0;
        protected virtual int RemoveIndex => List.Count - 1;
        public string Remove()
        {
            string result = null;
            if (List.Count > 0)
            {
                result = List[RemoveIndex];
                List.RemoveAt(RemoveIndex);
            }

            return result;
        }

    }
}
