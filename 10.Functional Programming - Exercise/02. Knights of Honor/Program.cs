namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(' ');

            Action<string> printName = (name) => Console.WriteLine($"Sir {name}");

            foreach (var name in names)
            {
                printName(name);
            }
        }
    }
}
