namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = ReadMatrix(N, N, " ");

            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
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
