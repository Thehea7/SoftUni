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


        public string AnalyzeAccessModifiers(string className)
        {
            StringBuilder sb = new StringBuilder();
            Type type = Type.GetType(className);

            FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            foreach (FieldInfo field in fields) { sb.AppendLine($"{field.Name} must be private!");}

            MethodInfo[] privateMethods = type
                .GetMethods(BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance)
                .Where(m => m.Name.StartsWith("set")).ToArray();
            foreach (MethodInfo method in privateMethods)
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }

            MethodInfo[] publicMethods = type
                .GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance)
                .Where(m => m.Name.StartsWith("set")).ToArray();
            foreach (MethodInfo method in publicMethods)
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            return sb.ToString().Trim();
        }
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
