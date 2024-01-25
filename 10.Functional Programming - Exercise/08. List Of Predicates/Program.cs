namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();

            Func<int, bool> isDivisible = number =>
            {
                foreach (int divider in dividers)
                {
                    if (number % divider != 0)
                    {
                        return false;
                    }
                }
                return true;
            };

            List<int> divisibleNumbers = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                if (isDivisible(i))
                {
                    divisibleNumbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", divisibleNumbers));
        }
    }
}
