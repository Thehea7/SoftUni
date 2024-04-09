using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08.CollectionHierarchy.Models.Interfaces;

namespace _08.CollectionHierarchy.Models
{
    public class MyList : AddRemoveCollection, ICount
    {
        protected override int AddIndex => 0;
        protected override int RemoveIndex => AddIndex;
        public int Used => List.Count;

    }
}
