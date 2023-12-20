namespace _02.AMinerTask
{

    class Resource
    {
        public Resource(string name)        
        {
            Name = name;
        }
        public string Name { get; set; }
        public long Quantity { get; set; }

        public  void AddQuantity(long quantity)
        {
            Quantity += quantity;
        }
        public override string ToString()
        {
            return $"{Name} -> {Quantity}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Resource> resourcesMap = new Dictionary<string, Resource>();
            string command;
            while ((command = Console.ReadLine()) != "stop")
            {
                string name = command;

                long quantity = long.Parse(Console.ReadLine());

                Resource currentResource = new Resource(name);

                if (!resourcesMap.ContainsKey(name))
                {
                    resourcesMap.Add(name, currentResource);
                }
                resourcesMap[name].AddQuantity(quantity);
            }

            foreach (var resource in resourcesMap)
            {
                Console.WriteLine(resource.Value);
            }

            

        }
    }
}