namespace _01._Generic_Box_of_int
{
    internal class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }

            string valueForComparison = Console.ReadLine();

            int count = box.CountGreaterThan(valueForComparison);
            Console.WriteLine(count);
        }
    }
}
