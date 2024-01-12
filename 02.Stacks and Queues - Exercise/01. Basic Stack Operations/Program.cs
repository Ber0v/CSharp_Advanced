namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int N = input[0];
            int S = input[1];
            int X = input[2];

            Stack<int> stack = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            
            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }

            if (stack.Count <= 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }

        }
    }
}
