namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int N = input[0];
            int S = input[1];
            int X = input[2];

            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            
            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
