namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] items = input[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in items)
                {
                    if (wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color][item]++;
                    }
                    else
                    {
                        wardrobe[color][item] = 1;
                    }
                }
            }

            string[] search = Console.ReadLine().Split();
            string searchColor = search[0];
            string searchClothing = search[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    if (color.Key == searchColor && item.Key == searchClothing)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
