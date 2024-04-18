using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AuthorProblem
{
    public class Tracker
    {
        [Author("Andrey")]
       public  void PrintMethodsByAuthor()
        {
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in types)
            {
                MethodInfo[] methods = type.GetMethods((BindingFlags)60)
                    .Where(m => m.CustomAttributes
                        .Any(a => a.AttributeType == typeof(AuthorAttribute)))
                    .ToArray();
                foreach (var methodInfo in methods)
                {
                    var attributes = methodInfo.GetCustomAttributes(false);
                    foreach (AuthorAttribute attribute in attributes)
                    {
                        Console.WriteLine($"{methodInfo.Name} is written by {attribute.Name}");
                    }
                }
            }
        }
    }
}
