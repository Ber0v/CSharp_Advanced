namespace _01._Action_Print
{
    internal class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(' ');

            Action<string> printName = (name) => Console.WriteLine(name);

            foreach (var name in names)
            {
                printName(name);
            }
        }
    }
}
