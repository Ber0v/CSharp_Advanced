namespace _02._Fishing_Competition
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int fishCaught = 0;
            int targetFish = 20;
            int row = -1;
            int col = -1;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = line[j];
                    if (line[j] == 'S')
                    {
                        row = i;
                        col = j;
                    }
                }
            }

            string command = Console.ReadLine();
            while (command != "collect the nets")
            {
                int newRow = row;
                int newCol = col;

                if (command == "up")
                {
                    newRow--;
                }
                else if (command == "down")
                {
                    newRow++;
                }
                else if (command == "left")
                {
                    newCol--;
                }
                else if (command == "right")
                {
                    newCol++;
                }

                if (newRow < 0)
                {
                    newRow = n - 1;
                }
                else if (newRow >= n)
                {
                    newRow = 0;
                }

                if (newCol < 0)
                {
                    newCol = n - 1;
                }
                else if (newCol >= n)
                {
                    newCol = 0;
                }

                if (matrix[newRow, newCol] == '-')
                {
                    matrix[newRow, newCol] = 'S';
                }
                else if (char.IsDigit(matrix[newRow, newCol]))
                {
                    int fishQuantity = int.Parse(matrix[newRow, newCol].ToString());
                    fishCaught += fishQuantity;
                    matrix[newRow, newCol] = 'S';
                    if (fishCaught >= targetFish)
                    {
                        Console.WriteLine("Success! You managed to reach the quota!");
                        Console.WriteLine($"Amount of fish caught: {fishCaught} tons.");
                        PrintMatrix(matrix);
                        return;
                    }
                }
                else if (matrix[newRow, newCol] == 'W')
                {
                    Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{newRow},{newCol}]");
                    return;
                }

                matrix[row, col] = '-';
                row = newRow;
                col = newCol;

                command = Console.ReadLine();
            }

            Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {targetFish - fishCaught} tons of fish more.");
            if (fishCaught > 0)
            {
                Console.WriteLine($"Amount of fish caught: {fishCaught} tons.");
            }
            PrintMatrix(matrix);
        }
        static void PrintMatrix(char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
