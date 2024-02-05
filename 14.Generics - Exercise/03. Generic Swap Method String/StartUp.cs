namespace _01._Generic_Box_of_String
{
    internal class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> items = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                items.Add(input);
            }

            Box<string> box = new Box<string>(null);

            string[] swapCommand = Console.ReadLine().Split(' ');
            int index1 = int.Parse(swapCommand[0]);
            int index2 = int.Parse(swapCommand[1]);

            box.Swap(items, index1, index2);

            foreach (var item in items)
            {
                box = new Box<string>(item);
                Console.WriteLine(box.ToString());
            }
        }
    }
}
