namespace _01._Offroad_Challenge
{
    internal class Program
    {
        static void Main()
        {
            int[] fuel = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] consumption = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] quantities = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int currentAltitude = 1;
            bool reachedTop = false;
            List<int> reachedAltitudes = new List<int>();
            for (int i = 0; i < fuel.Length; i++)
            {
                int result = fuel[3 - i] - consumption[i];
                if (result >= quantities[currentAltitude - 1])
                {
                    Console.WriteLine($"John has reached: Altitude {currentAltitude}");
                    reachedAltitudes.Add(currentAltitude);
                }
                else if (result <= quantities[currentAltitude - 1])
                {
                    Console.WriteLine($"John did not reach: Altitude {currentAltitude}");
                    break;
                }
                currentAltitude++;

                if (reachedAltitudes.Count == quantities.Length)
                {
                    reachedTop = true;
                    break;
                }
            }

            if (reachedTop)
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }
            else
            {
                if (reachedAltitudes.Count == 0)
                {
                    Console.WriteLine($"John failed to reach the top.\nJohn didn't reach any altitude.");
                }
                else
                {
                    Console.WriteLine($"John failed to reach the top.\nReached altitudes: Altitude {string.Join(", Altitude ", reachedAltitudes)}");
                }
            }
        }
    }
}