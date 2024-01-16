namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main()
        {
            int[] N = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int rows = N[0];
            int cols = N[1];

            string[,] matrix = ReadMatrix(rows, cols, " ");

            int count = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col] &&
                        matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
        static string[,] ReadMatrix(int rows, int cols, string separator)
        {
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowArray = Console.ReadLine().Split(separator);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowArray[col];
                }
            }
            return matrix;
        }
    }
}
