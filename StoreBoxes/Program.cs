using System;
using System.Linq;
using System.Collections.Generic;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxLst = new List<Box>();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0] == "end")
                {
                    List<Box> output = boxLst.OrderByDescending(s => s.PriceBox).ToList();
                    foreach (Box box in output)
                    {
                        Console.WriteLine(box.SerialNumber);
                        Console.WriteLine("-- " + box.Item.Name + $" - ${box.Item.Price:F2}:" + box.ItemQuantity);
                        Console.WriteLine($"-- ${box.PriceBox:F2}");
                    }
                    break;
                }
                Box newBox = new Box();
                newBox.SerialNumber = int.Parse(input[0]);
                newBox.Item.Name = input[1];
                newBox.Item.Price = decimal.Parse(input[3]);
                newBox.ItemQuantity = int.Parse(input[2]);
                newBox.PriceBox = newBox.Item.Price * newBox.ItemQuantity;
                boxLst.Add(newBox);
            }
        }
    }

    class Item
    { 
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box 
    {
        public Box()
        { 
            Item = new Item();
        }
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity{ get; set; }
        public decimal PriceBox { get; set; }
    }
}
