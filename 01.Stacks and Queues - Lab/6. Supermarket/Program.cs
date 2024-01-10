namespace _6._Supermarket
{
    internal class Program
    {
        static void Main()
        {
            Queue<string> names = new Queue<string>();
            string name;
            while ((name = Console.ReadLine()) != "End")
            {
                if (name == "Paid")
                {
                    foreach (var person in names)
                    {
                        Console.WriteLine(person);
                    }
                    names.Clear();
                    continue;
                }
                names.Enqueue(name);
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
