using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem4
{
    internal class Problem5
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToArray();
            List<Box> boxes = new List<Box>();
            string name;
            decimal price = 0;
            string serialNumber;
            int itemQuantity;
            while (input[0] != "end")
            {
                name = input[1];
                price = decimal.Parse(input[3]);
                var item = new Item(name, price);
                //
                serialNumber = input[0];
                itemQuantity = int.Parse(input[2]);
                var box = new Box(serialNumber, itemQuantity, item);
                boxes.Add(box);
                //
                input = Console.ReadLine()
                .Split(' ')
                .ToArray();
            }
            foreach (var box in boxes.OrderByDescending(x=>x.BoxPrice))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");

            }
        }
    }
    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    public class Box
    {
        public Box(string serialNumber, int itemQuantity, Item item)
        {
            SerialNumber = serialNumber;
            ItemQuantity = itemQuantity;
            Item = item;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal BoxPrice => Item.Price * ItemQuantity;
    }
}
