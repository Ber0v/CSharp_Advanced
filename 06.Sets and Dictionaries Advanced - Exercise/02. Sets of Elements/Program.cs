namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main()
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            
            int[] lengths = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < lengths[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstSet.Add(num);
            }
            for (int i = 0; i < lengths[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                secondSet.Add(num);
            }
            
            firstSet.IntersectWith(secondSet);
            Console.WriteLine(string.Join(" ", firstSet));
        }
    }
}
