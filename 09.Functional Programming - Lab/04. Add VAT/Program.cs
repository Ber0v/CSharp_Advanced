namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main()
        {
            double[] nums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).Select(x => x * 1.2).ToArray();

            foreach (var n in nums)
            {
                Console.WriteLine($"{n:F2}");
            }
        }
    }
}
