namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());


            string text = string.Empty;
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (int.Parse(command[0]))
                {
                    case 1:
                        text += command[1];
                        stack.Push(text);
                        break;
                    case 2:
                        int charsForErase = int.Parse(command[1]);
                        text = text.Substring(0, text.Length - charsForErase);
                        stack.Push(text);
                        break;
                    case 3:
                        int index = int.Parse(command[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case 4:
                        stack.Pop();

                        if (stack.Count > 0)
                        {
                            text = stack.Peek();
                        }
                        else
                        {
                            text = string.Empty;
                        }

                        break;
                }
            }
        }
    }
}
