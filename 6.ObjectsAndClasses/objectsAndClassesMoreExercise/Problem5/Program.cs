using System.Reflection;

namespace Problem5
{
    internal class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            //people input start
            var peopleInput = Console.ReadLine()
                .Split(";")
                .Where(item => !string.IsNullOrWhiteSpace(item))
                .ToList();
            people = peopleInput
                .Select(s => s.Split('='))
                .Select(parts => new Person(parts[0], decimal.Parse(parts[1])))
                .ToList();
            //people input end
            
            //products input start
            var productsInput = Console.ReadLine()
                .Split(";")
                .Where(item => !string.IsNullOrWhiteSpace(item))
                .ToList();
            products = productsInput
                .Select(s => s.Split('='))
                .Select(parts => new Product(parts[0], decimal.Parse(parts[1])))
                .ToList();
            //products input end

            // EXECUTION START//
            string command;
            string personName;
            string productName;
            while ((command = Console.ReadLine()) != "END")
            {
                List<string> commandList = command
                    .Split(" ")
                    .ToList();
                personName = commandList[0];
                productName = commandList[1];
                var person = people.FirstOrDefault(p => p.Name == personName);
                if (person != null)
                {
                    person.OutputMassage(products.FirstOrDefault(p => p?.Name == productName));
                }
            }
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
            // EXECUTION END//
        }
    }
    public class Person
    {
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>();
        }
        public void OutputMassage(Product product)
        {
            if (Money >= product.Cost)
            {
                Money -= product.Cost;
                Products.Add(product);
                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
            }
        }
        public override string ToString()
        {
            if (Products.Count != 0)
            {
                return $"{Name} - {string.Join(", ", Products)}";
            }
            else
            {
                return $"{Name} - Nothing bought";
            }
        }

        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<Product> Products { get; set; }
    }
    public class Product
    {
        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
        public override string ToString()
        {
            return $"{Name}";
        }

        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
    
}