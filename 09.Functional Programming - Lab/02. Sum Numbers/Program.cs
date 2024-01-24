namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int[] num = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Console.WriteLine(num.Length);
            Console.WriteLine(num.Sum());
        }
    }
}
