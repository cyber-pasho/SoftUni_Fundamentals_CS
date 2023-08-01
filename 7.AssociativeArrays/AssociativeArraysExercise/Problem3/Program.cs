namespace Problem3
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<Product, decimal> products = new Dictionary<Product, decimal>();
            List<Product> listProducts = new List<Product>();
            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                var productInput = input
                    .Split(" ")
                    .ToArray();
                string name = productInput[0];
                decimal price = decimal.Parse(productInput[1]);
                int quantity = int.Parse(productInput[2]);
                Product existingProduct = listProducts.FirstOrDefault(p => p.Name == name);
                if (existingProduct == null)
                {
                    Product product = new Product(name, price, quantity);
                    listProducts.Add(product);
                }
                else
                {
                    existingProduct.Price = price;
                    existingProduct.Quantity += quantity;
                }
            }
            foreach (var item in listProducts)
            {
                products.Add(item, item.TotalPrice(item.Price, item.Quantity));
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key.Name} -> {product.Value}");
            }
        }
    }
    public class Product
    {
        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public decimal TotalPrice(decimal price, int quantity)
        {
            decimal totalPrice = quantity * price;
            return totalPrice;
        }
        public string Name  { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}