namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (var simbol in input)
            {
                if (stack.Any())
                {
                    char check = stack.Peek();
                    if (check == '{' && simbol == '}')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (check == '[' && simbol == ']')
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (check == '(' && simbol == ')')
                    {
                        stack.Pop();
                        continue;
                    }
                }
                stack.Push(simbol);
            }
            Console.WriteLine(!stack.Any() ? "YES" : "NO");
        }
    }
}