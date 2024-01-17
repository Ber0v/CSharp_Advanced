namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main()
        {
            HashSet<string> names = new HashSet<string>();

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                names.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join("\n", names));
        }
    }
}
