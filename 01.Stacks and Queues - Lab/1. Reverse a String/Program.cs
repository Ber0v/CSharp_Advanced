namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main()
        {
            Stack<char> stack = new Stack<char>();
            char[] input = Console.ReadLine().ToArray();

            foreach (var item in input)
            {
                stack.Push(item);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
