namespace _04._Even_Times
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<int, int> nums = new Dictionary<int, int>();

            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (nums.ContainsKey(num))
                {
                    nums[num]++;
                }
                else
                {
                    nums[num] = 1;
                }
            }

            foreach (var n in nums)
            {
                if (n.Value % 2 == 0)
                {
                    Console.WriteLine(n.Key);
                    break;
                }
            }
        }
    }
}
