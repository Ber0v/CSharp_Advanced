namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, List<string>>> Earth = new Dictionary<string, Dictionary<string, List<string>>>();

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] earth = Console.ReadLine().Split(" ");
                string continents = earth[0];
                string countries = earth[1];
                string cities = earth[2];

                if (!Earth.ContainsKey(continents))
                {
                    Earth.Add(continents, new Dictionary<string, List<string>>());
                }
                if (!Earth[continents].ContainsKey(countries))
                {
                    Earth[continents].Add(countries, new List<string>());
                }
                    Earth[continents][countries].Add(cities);
            }

            foreach (var (Continent, contri) in Earth)
            {
                Console.WriteLine($"{Continent}:");
                foreach (var (contris, citi) in contri)
                {
                    Console.WriteLine($"  {contris} -> {string.Join(", ", citi)}");
                }
            }
        }
    }
}
