using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main()
        {
            int[] N = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = N[0];
            int cols = N[1];

            int[][] matrix = new int[rows][];

            int maxsum = int.MinValue;
            int maxrow = 0;
            int maxcol = 0;

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int sum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            sum += matrix[row + i][col + j];
                        }
                    }

                    if (maxsum < sum)
                    {
                        maxsum = sum;
                        maxrow = row;
                        maxcol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxsum}");
            for (int i = maxrow; i < maxrow + 3; i++)
            {
                for (int j = maxcol; j < maxcol + 3; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}