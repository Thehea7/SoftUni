using System.Text.Json;
using ConsoleApp1;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

Person person  = new Person();
person.Name = "Petar Petrov";
person.Age  = 30;
person.Height  = 175;
person.Weight = 85.7;

var options = new JsonSerializerOptions()
{   
    WriteIndented = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    
};

string personData = JsonSerializer.Serialize(person, options);

Console.WriteLine(personData);

Person?  person2 = JsonSerializer.Deserialize<Person>(personData, options);

Console.WriteLine(person2);

string data = JsonConvert.SerializeObject(person2, Formatting.Indented
);

Console.WriteLine(data);

Person? person3 = JsonConvert.DeserializeObject<Person>(data);

Console.WriteLine(person3);