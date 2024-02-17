namespace _01._Chicken_Snack
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> money = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            Queue<int> price = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());

            int count = Count(money, price);

            if (count >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {count} foods.");
            }
            else if (count > 0)
            {
                Console.WriteLine($"Henry ate: {count} food{(count > 1 ? "s" : "")}.");
            }
            else
            {
                Console.WriteLine("Henry remained hungry. He will try next weekend again.");
            }
        }

        private static int Count(Stack<int> money, Queue<int> price)
        {
            int count = 0;

            while (money.Count > 0 && price.Count > 0)
            {
                int moneyneed = money.Pop();
                int pricefor = price.Dequeue();

                if (moneyneed == pricefor)
                {
                    count++;
                }
                else if (moneyneed > pricefor)
                {
                    count++;
                    int diffrence = moneyneed - pricefor;

                    if (money.Count > 0)
                    {
                        money.Push(money.Pop() + diffrence);
                    }
                }
            }

            return count;
        }
    }
}
