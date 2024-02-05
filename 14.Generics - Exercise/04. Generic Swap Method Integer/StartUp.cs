namespace _01._Generic_Box_of_int
{
    internal class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> items = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                items.Add(input);
            }

            Box<int> box = new Box<int>(0);

            string[] swapCommand = Console.ReadLine().Split(' ');
            int index1 = int.Parse(swapCommand[0]);
            int index2 = int.Parse(swapCommand[1]);

            box.Swap(items, index1, index2);

            foreach (var item in items)
            {
                box = new Box<int>(item);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
