namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int rows = N;
            int cols = N;

            int[,] matrix = ReadMatrix(rows, cols, " ");

            int sumprim = 0;
            int sumsec = 0;

            for (int i = 0; i < N; i++)
            {
                sumprim += matrix[i, i];
            }
            for (int i = 0; i < N; i++)
            {
                sumsec += matrix[i, (N - 1) - i];
            }

            Console.WriteLine(Math.Abs(sumsec - sumprim));
        }
        static int[,] ReadMatrix(int rows, int cols, string separator)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowArray = Console.ReadLine().Split(separator).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowArray[col];
                }
            }
            return matrix;
        }
    }
}
