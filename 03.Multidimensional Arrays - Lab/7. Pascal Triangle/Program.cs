namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            long [][] Pascal = new long[size][];

            Pascal[0] = new long[1] { 1 };

            for (int row = 1; row < size; row++)
            {
                Pascal[row] = new long[row + 1];

                for (int col = 0; col < Pascal[row].Length; col++)
                {
                    if (col < Pascal[row - 1].Length)
                        Pascal[row][col] += Pascal[row - 1][col];
                    if (col > 0)
                        Pascal[row][col] += Pascal[row - 1][col - 1];
                }
            }
            foreach (var row in Pascal)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
