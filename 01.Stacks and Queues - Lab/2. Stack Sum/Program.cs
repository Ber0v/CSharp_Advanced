using System.Data;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] depend = command.Split();

                switch (depend[0])
                {
                    case "add":
                        stack.Push(int.Parse(depend[1]));
                        stack.Push(int.Parse(depend[2]));
                        break;
                    case "remove":
                        if (int.Parse(depend[1]) <= stack.Count)
                        {
                            for (int i = 0; i < int.Parse(depend[1]); i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
