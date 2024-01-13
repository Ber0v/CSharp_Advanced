namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = ReadMatrix(rows, cols, ", ");

            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum+= matrix[i, j];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);



            int[,] ReadMatrix(int rows, int cols, string separator)
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
}
