using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WorkInClass
{


    internal class StartUp
    {

        static void Main(string[] args)
        {
            //NewMethod();

            // GettingTypeInformation();

            // GettingInterfacesInformation();

            //GettingFieldsInfo();  Same princip for properties 

            // GettingInfoForConstructorAndParameter();  Use same logic for Methods and parameters

            // ActivatorCreateInstancesOfType();

            // GetClassesThatAreAssignableTo_From();

            //Attributes();
        }

        private static void Attributes()
        {
            Dog dog = new Dog();

            Type type = typeof(Dog);
            //DocumentationAttribute attribute = type.GetCustomAttribute<DocumentationAttribute>();
            //Console.WriteLine(attribute.MoreInfo);

            List<DocumentationAttribute> attributes = type.GetCustomAttributes<DocumentationAttribute>().ToList();

            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute.MoreInfo);

                Type[] types = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.GetCustomAttribute<DocumentationAttribute>(false) != null)
                    .ToArray();

                foreach (var type1 in types)
                {
                    DocumentationAttribute attr = type1.GetCustomAttribute<DocumentationAttribute>();

                    Console.WriteLine($"Documentation for {type1.Name} - {attr.MoreInfo}");
                }
            }
        }

        private static void GetClassesThatAreAssignableTo_From()
        {
            Console.WriteLine(typeof(Dog).IsAssignableFrom(typeof(Animal)));
            Console.WriteLine(typeof(Dog).IsAssignableTo(typeof(Animal)));

            Type[] types = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsAssignableTo(typeof(Animal)) && t.Name != typeof(Animal).Name)
                .ToArray();

            foreach (Type t in types)
            {
                Console.WriteLine(t.Name);
            }
        }

        private static void ActivatorCreateInstancesOfType()
        {
            Type type = typeof(Dog);

            Dog leksa = (Dog)Activator.CreateInstance(type, "Leksa", 150m);
            Dog leksa2 = (Dog)Activator.CreateInstance(type, "Leksa");
            Dog leksa3 = (Dog)Activator.CreateInstance(type);
            Console.WriteLine(leksa);
            Console.WriteLine(leksa2);
            Console.WriteLine(leksa3);
        }

        private static void GettingInfoForConstructorAndParameter()
        {
            Type type = typeof(Dog);
            ConstructorInfo[] constructors = type.GetConstructors((BindingFlags)60);

            foreach (ConstructorInfo ctor in constructors)
            {
                Console.WriteLine(ctor.Name);
                ParameterInfo[] parameters = ctor.GetParameters();
                Console.WriteLine(parameters.Length);
                foreach (ParameterInfo parameter in parameters)
                {
                    Console.WriteLine(parameter.Name);
                    Console.WriteLine(parameter.ParameterType.Name);
                    Console.WriteLine(parameter.IsOptional);
                }


            }

            ConstructorInfo constructor = type.GetConstructors((BindingFlags)60)[0]; // Option 1
            Dog leksa = (Dog)constructor.Invoke(new object[] { "Leksa", 150m });
            Console.WriteLine(leksa);
        }

        private static void GettingFieldsInfo()
        {
            //Obtaining public Fields !! Not Properties

            Type type = typeof(Dog);
            //FieldInfo publicFieldName = type.GetField("name", BindingFlags.Static
            //                                                  | BindingFlags.Instance
            //                                                  | BindingFlags.Public
            //                                                  | BindingFlags.NonPublic); // gets all fields

            FieldInfo publicFieldName = type.GetField("name", (BindingFlags)60); // gets all fields, short for the above
            Console.WriteLine((int)BindingFlags.Static);
            Console.WriteLine((int)BindingFlags.Instance);
            Console.WriteLine((int)BindingFlags.Public);
            Console.WriteLine((int)BindingFlags.NonPublic);
            Console.WriteLine(16 | 32 | 4 | 8);
            Console.WriteLine(publicFieldName.IsPrivate);
            Console.WriteLine(publicFieldName.IsPublic);
            Console.WriteLine(publicFieldName.IsAssembly); // Internal
            Console.WriteLine(publicFieldName.IsFamily); // Protected


            Dog myDog = new Dog();
            Console.WriteLine(publicFieldName.GetValue(myDog));  //Get Value requires an object
            publicFieldName.SetValue(myDog, "Rita");   // Same for SetValue
            Console.WriteLine(publicFieldName.GetValue(myDog));  //Get Value requires an object


            FieldInfo[] publicFields = type.GetFields();

            foreach (var publicField in publicFields)
            {
                Console.WriteLine(publicField.FieldType);
            }

            // Obtain all fields !!Not Properties

            FieldInfo[] allFields = type.GetFields(
                BindingFlags.Static
                | BindingFlags.Instance
                | BindingFlags.Public
                | BindingFlags.NonPublic);

            foreach (var field in allFields)
            {
                Console.WriteLine(field.Name);
            }



            void PrintTypeInformation(Type type)
            {
                Console.WriteLine($"Name {type.Name}");
                Console.WriteLine($"FullName {type.FullName}");
                Console.WriteLine($"Assembly {type.Assembly}");
                Console.WriteLine($"IsArray {type.IsArray}");
                Console.WriteLine($"IsPublic {type.IsPublic}");
                Console.WriteLine($"IsGenericType {type.IsGenericType}");
                Console.WriteLine($"IsAbstract {type.IsAbstract}");
                Console.WriteLine($"IsClass {type.IsClass}");
                Console.WriteLine($"IsSealed {type.IsSealed}");
            }
        }

        private static void GettingInterfacesInformation()
        {
            Type[] interfaces = typeof(List<>).GetInterfaces();

            foreach (Type interfaceType in interfaces)
            {
                PrintTypeInformation(interfaceType);
            }



            void PrintTypeInformation(Type type)
            {
                Console.WriteLine($"Name {type.Name}");
                Console.WriteLine($"FullName {type.FullName}");
                Console.WriteLine($"Assembly {type.Assembly}");
                Console.WriteLine($"IsArray {type.IsArray}");
                Console.WriteLine($"IsPublic {type.IsPublic}");
                Console.WriteLine($"IsGenericType {type.IsGenericType}");
                Console.WriteLine($"IsAbstract {type.IsAbstract}");
                Console.WriteLine($"IsClass {type.IsClass}");
                Console.WriteLine($"IsSealed {type.IsSealed}");
            }
        }

        private static void GettingTypeInformation()
        {
            //Type type = typeof(Dog); //get  Type before compilation

            // Type type = Type.GetType(Console.ReadLine());  // Dynamic, get the Type inMotion - RunTime

            //Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == "Dog"); my test

            Dog dog = new Dog(); Type type = dog.GetType(); // Get the Type by Instance

            Type type1 = type.BaseType; // Gets the parent class

            Console.WriteLine($"Name {type.Name}");
            Console.WriteLine($"FullName {type.FullName}");
            Console.WriteLine($"Assembly {type.Assembly}");
            Console.WriteLine($"IsArray {type.IsArray}");
            Console.WriteLine($"IsPublic {type.IsPublic}");
            Console.WriteLine($"IsGenericType {type.IsGenericType}");
            Console.WriteLine($"IsAbstract {type.IsAbstract}");
            Console.WriteLine($"IsClass {type.IsClass}");
            Console.WriteLine($"IsSealed {type.IsSealed}");
        }

        private static void NewMethod()
        {
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine(type.Name);
                Console.WriteLine(type.FullName);
                Console.WriteLine(type.IsValueType);
                Console.WriteLine(type.DeclaringType);
                Console.WriteLine(type.ReflectedType);
                Console.WriteLine(type.DeclaringType);

            }
        }
    }
}
