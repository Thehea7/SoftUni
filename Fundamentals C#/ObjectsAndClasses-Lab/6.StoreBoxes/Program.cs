namespace _6.StoreBoxes
{
    class Item
    {
        public Item(string v1, double v2)
        {
            Name = v1;
            Price = v2;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public double PriceForABox { get; set; }

    }
    internal class Program
    {
        static void Main()
        {
          string command = string.Empty;
            List<Box> boxes = new List<Box>();
            while((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split().ToArray();

                double itemPrice = double.Parse(input[3]);
                int itemQuantity = int.Parse(input[2]);

                Item currentItem = new Item(input[1], itemPrice);

                Box currentBox = new Box();
                currentBox.Item = currentItem;
                currentBox.Quantity = itemQuantity;
                currentBox.SerialNumber = input[0];
                currentBox.PriceForABox = itemPrice * itemQuantity;
                boxes.Add(currentBox);

            }
            var sortedBoxes = boxes.OrderByDescending(x => x.PriceForABox).ToList();

            foreach(Box box in sortedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }
}