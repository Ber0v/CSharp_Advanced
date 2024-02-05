namespace _01._Generic_Box_of_int
{
    internal class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Add(input);
            }

            double valueForComparison = double.Parse(Console.ReadLine());

            double count = box.CountGreaterThan(valueForComparison);
            Console.WriteLine(count);
        }
    }
}
