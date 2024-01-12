namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());

            Console.WriteLine(queue.Max());

            while (queue.Any())
            {

                if (queue.Peek() <= quantity)
                {
                    quantity -= queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Orders left: " + string.Join(" ", queue));
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}
