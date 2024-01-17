namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, double>> stores = new Dictionary<string, Dictionary<string, double>>();

            string input = null;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] command = input.Split(", ");
                if (command.Length == 3)
                {
                    string store = command[0];
                    string product = command[1];
                    double price = double.Parse(command[2]);

                    if (!stores.ContainsKey(store))
                    {
                        stores.Add(store, new Dictionary<string, double>());
                    }
                    if (!stores[store].ContainsKey(product))
                    {
                        stores[store].Add(product, 0);
                    }
                    stores[store][product] = price;
                }
            }

            stores = stores.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);

            foreach (var (store, products) in stores)
            {
                Console.WriteLine($"{store}->");
                foreach (var (product, price) in products)
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }
        }
    }
}