using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {



        public string StealFieldInfo(string className, params string[] fields)
        {
            Type type = Type.GetType(className);

            FieldInfo[] fieldArray = type.GetFields((BindingFlags)60);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Class under investigation: {type.Name}");
            foreach (var fieldInfo in fieldArray)
            {
                if (fields.Contains(fieldInfo.Name))
                {
                    sb.AppendLine($"{fieldInfo.Name} = {fieldInfo.GetValue(new Hacker())}");
                }
            }
             
            return sb.ToString().Trim();
        }
    }
}
