namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> numbers = new List<int>(input);

            string command = null;
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = ApplyOperation(numbers, Add);
                        break;
                    case "multiply":
                        numbers = ApplyOperation(numbers, Multiply);
                        break;
                    case "subtract":
                        numbers = ApplyOperation(numbers, Subtract);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                }
            }
        }
        static List<int> ApplyOperation(List<int> numbers, Func<int, int> operation)
        {
            List<int> result = new List<int>();
            foreach (int num in numbers)
            {
                result.Add(operation(num));
            }
            return result;
        }

        static int Add(int num)
        {
            return num + 1;
        }

        static int Multiply(int num)
        {
            return num * 2;
        }

        static int Subtract(int num)
        {
            return num - 1;
        }
    }
}
