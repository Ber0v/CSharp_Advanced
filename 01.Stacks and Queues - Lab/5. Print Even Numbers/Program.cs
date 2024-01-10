namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(nums);

            string even = "";
            while (queue.Count > 0)
            {
                int num = queue.Dequeue();
                if (num % 2 == 0)
                {
                    even += num; 
                    if (queue.Count > 0)
                    {
                        even += ", ";
                    }
                }
            }
            Console.WriteLine(even);
        }
    }
}
