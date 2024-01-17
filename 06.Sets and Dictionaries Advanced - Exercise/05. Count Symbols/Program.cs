namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> s = new SortedDictionary<char, int>();

            foreach (char ch in text)
            {
                if (s.ContainsKey(ch))
                {
                    s[ch]++;
                }
                else
                {
                    s[ch] = 1;
                }
            }

            foreach (var pair in s)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }
        }
    }
}
