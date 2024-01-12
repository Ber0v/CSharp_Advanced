namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            Queue<int[]> pumps = new();

            for (int i = 0; i < N; i++)
            {
                int[] pumpData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                pumps.Enqueue(pumpData);
            }

            int position = 0;

            while (true)
            {
                int fuel = 0;

                foreach (var pump in pumps)
                {
                    fuel += pump[0] - pump[1];
                    if (fuel < 0)
                    {
                        position++;
                        pumps.Enqueue(pumps.Dequeue());
                        break;
                    }
                }
                if (fuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(position);
        }
    }
}
