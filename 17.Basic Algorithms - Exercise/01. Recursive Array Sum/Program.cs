namespace _01._Recursive_Array_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Console.WriteLine(ArraySum(arr, 0));
        }

        public static int ArraySum(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }
            return arr[index] + ArraySum(arr, index + 1);
        }
    }
}
