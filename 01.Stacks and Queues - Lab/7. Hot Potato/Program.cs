namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main()
        {
            string[] people = Console.ReadLine().Split();
            int patato = int.Parse(Console.ReadLine());
            Queue<string> players = new Queue<string>(people);

            while (players.Count != 1)
            {
                for (int i = 1; i < patato; i++)
                {
                    string p = players.Dequeue();
                    players.Enqueue(p);
                }

                Console.WriteLine($"Removed {players.Dequeue()}");
            }
            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}
