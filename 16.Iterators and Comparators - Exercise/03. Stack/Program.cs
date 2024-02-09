namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> numbers = new();

            string command;
            while (true)
            {
                command = Console.ReadLine();

                if (command == "END")
                {
                    if (numbers.Count > 0)
                    {
                        Console.WriteLine(string.Join(Environment.NewLine, numbers));
                        Console.WriteLine(string.Join(Environment.NewLine, numbers));
                    }

                    break;
                }

                string[] commandDetails = command.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string action = commandDetails[0];

                switch (action)
                {
                    case "Push":
                        int[] itemsToPush = commandDetails.Skip(1).Select(int.Parse).ToArray();
                        foreach (int item in itemsToPush)
                        {
                            numbers.Push(item);
                        }
                        break;
                    case "Pop":
                        try
                        {
                            numbers.Pop();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }
            }
        }
    }
}