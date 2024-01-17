using System.Collections.Immutable;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main()
        {
            SortedSet<string> UniqueElements = new SortedSet<string>();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] elements = Console.ReadLine().Split(" ");
                foreach (string element in elements)
                {
                    UniqueElements.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", UniqueElements));
        }
    }
}
