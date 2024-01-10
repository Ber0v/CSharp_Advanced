namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> Bracket = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    Bracket.Push(i);
                }
                else if (input[i] == ')')
                {
                    int start = Bracket.Pop();
                    int end = i;

                    string sub = input.Substring(start, end - start + 1);
                    Console.WriteLine(sub);
                }

            }
        }
    }
}
