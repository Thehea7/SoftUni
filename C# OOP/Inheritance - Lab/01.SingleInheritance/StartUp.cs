using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class StartUp
    {
        static void Main()
        {
            Dog dog = new Animal() as Dog;
            
            dog.Bark();
            dog.Eat();
        }
    }
}
