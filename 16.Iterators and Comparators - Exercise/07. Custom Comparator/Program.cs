namespace _07._Custom_Comparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Func<int, int, int> compareNumbers = (x, y) =>
            {
                if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }
                else if (x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }

                return x.CompareTo(y);
            };

            Array.Sort(numbers, (x, y) => compareNumbers(x, y));
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}