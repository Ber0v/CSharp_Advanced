namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Func<int[], int> small = n => n.Min();

            int smallestNumber = small(nums);
            Console.WriteLine(smallestNumber);
        }
    }
}