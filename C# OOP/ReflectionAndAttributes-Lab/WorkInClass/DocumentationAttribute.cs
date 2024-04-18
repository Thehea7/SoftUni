using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkInClass
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)] // default is applicable to all, 1 attribute
    public class DocumentationAttribute :Attribute
    {
        public DocumentationAttribute()
        {
            
        }
        public DocumentationAttribute(string moreInfo)
        {
            MoreInfo = moreInfo;
        }
        public string MoreInfo { get; set; }
    }
}
