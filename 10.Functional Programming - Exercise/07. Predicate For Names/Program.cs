namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ");
            var filteredNames = names.Where(name => name.Length <= N);

            foreach (var name in filteredNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
