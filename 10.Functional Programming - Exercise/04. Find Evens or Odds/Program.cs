namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main()
        {
            int[] inputRange = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lowerBound = inputRange[0];
            int upperBound = inputRange[1];

            string command = Console.ReadLine();

            Predicate<int> isEven = (num) => num % 2 == 0;
            Predicate<int> isOdd = (num) => num % 2 != 0;

            switch (command)
            {
                case "even":
                    var evenNumbers = Enumerable.Range(lowerBound, upperBound - lowerBound + 1).Where(num => isEven(num));
                    Console.WriteLine(string.Join(" ", evenNumbers));
                    break;
                case "odd":
                    var oddNumbers = Enumerable.Range(lowerBound, upperBound - lowerBound + 1).Where(num => isOdd(num));
                    Console.WriteLine(string.Join(" ", oddNumbers));
                    break;
            }
        }
    }
}
