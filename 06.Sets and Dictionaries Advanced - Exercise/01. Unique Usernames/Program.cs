namespace _01._Unique_Usernames
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
