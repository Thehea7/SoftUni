using System.Xml.Linq;
using System.Xml.Serialization;
using xmlDemo;


var family = new Family()
{
    FamilyName = "Petrovi",
    Members = new Person[]
    {
        new Person()
        {
            Name = "Petar",
            Age = 20
        },
        new Person()
        {
            Name = "Penka",
            Age = 21
        }
    }
};

XmlSerializer serializer = new XmlSerializer(typeof(Family), new XmlRootAttribute("Family"));

using (StreamWriter writer = new StreamWriter("family.xml"))
{
    serializer.Serialize(writer, family);

}


using StreamReader reader = new StreamReader("family.xml") ;

    var family2 = (Family?)serializer.Deserialize(reader);
    Console.WriteLine(family2.FamilyName);



//string xml = @"<?xml version=""1.0""?>
//<library name=""Developer's Library"">
// <book>
// <title>Professional C# and .NET</title>
// <author>Christian Nagel</author>
// <isbn>978-0-470-50225-9</isbn>
// </book>
// <book>
// <title>Teach Yourself XML in 10
//Minutes</title>
// <author>Andrew H. Watt</author>
// <isbn>978-0-672-32471-0</isbn>
// </book>
//</library>";

//XDocument doc = XDocument.Parse(xml);
//int level = 0;
//PrintStructure(doc.Elements(), level);




// static void PrintStructure(IEnumerable<XElement> elements, int level)
//{
//    int currentLevel = level;
//    if (elements.Count() == 0)
//    {
//        currentLevel--;
//        return;
//    }
//    currentLevel++;
//    foreach (XElement element in elements)
//    {
//        Console.WriteLine($"{new string(' ', currentLevel)}{element.Name}");
        
//        PrintStructure(element.Elements(), currentLevel);
//    }
    
//}

