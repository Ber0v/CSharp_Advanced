namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int num = int.Parse(Console.ReadLine());
            Array.Reverse(nums);
            Predicate<int> isOdd = (n) => n % num != 0;

            if (num % 2 == 0)
            {
                Console.WriteLine(string.Join(" ", nums.Where(n => isOdd(n))));
            }
            else
            {
                Console.WriteLine(string.Join(" ", nums.Where(n => isOdd(n))));
            }

        }
    }
}
