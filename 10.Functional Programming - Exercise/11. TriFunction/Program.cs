namespace _11._TriFunction
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string> (Console.ReadLine().Split());
            string result = FindName(names, n);
            Console.WriteLine(result);
        }

        static string FindName(List<string> names, int n)
        {
            foreach (string name in names)
            {
                if (GetSumOfCharacters(name) >= n)
                {
                    return name;
                }
            }
            return null;
        }

        static int GetSumOfCharacters(string name)
        {
            int sum = 0;
            foreach (char c in name)
            {
                sum += (int)c;
            }
            return sum;
        }
    }
}
