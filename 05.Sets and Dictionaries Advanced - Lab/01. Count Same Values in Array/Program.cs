namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<double, int> times = new Dictionary<double, int>();

            double[] nums = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                if (times.ContainsKey(nums[i]))
                {
                    times[nums[i]]++;
                }
                else
                {
                    times.Add(nums[i], 1);
                }
            }

            foreach (var key in times.Keys)
            {
                Console.WriteLine($"{key} - {times[key]} times");
            }
        }
    }
}
