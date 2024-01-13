namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            char[,] matrix = ReadMatrix(N, N);

            char symbol = char.Parse(Console.ReadLine());
            bool found = true;

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        found = false;
                        return;
                    }
                }
            }

            if (found)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }

        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }
    }
}
