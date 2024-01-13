namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main()
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = ReadMatrix(rows, cols, ", ");
            int maxsum = matrix[0,0];
            int maxrow = 0;
            int maxcol = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > maxsum)
                    {
                        maxrow = row;
                        maxcol = col;
                        maxsum = sum;
                    }

                }
            }
            Console.WriteLine(matrix[maxrow, maxcol]+" "+matrix[maxrow, maxcol+1]);
            Console.WriteLine(matrix[maxrow+1, maxcol]+" "+matrix[maxrow+1, maxcol+1]);
            Console.WriteLine(maxsum);
        }

        static int[,] ReadMatrix(int rows, int cols, string separator)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(separator).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }
    }
}
