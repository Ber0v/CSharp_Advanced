namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] largest = nums.OrderByDescending(x => x).Take(3).ToArray();

                Console.Write(string.Join(" ", largest));
        }
    }
}
