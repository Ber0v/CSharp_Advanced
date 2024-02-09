namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();
            ListyIterator<string> listyIterator = new(items);
            string input;
            while (true)
            {
                input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                switch (input)
                {
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
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