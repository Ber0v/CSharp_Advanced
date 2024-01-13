namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = ReadMatrix(rows, cols, " ");

            for (int col = 0; col < cols; col++)
            {
                int sum = 0;
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }

        static int[,] ReadMatrix(int rows, int cols, string separator)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(separator).Select(int.Parse).ToArray();

                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }
    }
}
