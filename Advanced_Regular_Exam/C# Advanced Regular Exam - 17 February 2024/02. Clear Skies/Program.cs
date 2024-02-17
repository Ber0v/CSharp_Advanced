namespace _02._Clear_Skies
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[,] airspace = new char[n, n];

            int jetfighterRow = -1;
            int jetfighterCol = -1;
            int enemyPlanesCount = 0;

            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    airspace[row, col] = rowData[col];
                    if (rowData[col] == 'J')
                    {
                        jetfighterRow = row;
                        jetfighterCol = col;
                    }
                    else if (rowData[col] == 'E')
                    {
                        enemyPlanesCount++;
                    }
                }
            }

            int armor = 300;
            bool missionFailed = false;
            bool missionAccomplished = false;

            while (true)
            {
                string command = Console.ReadLine();
                int nextRow = jetfighterRow;
                int nextCol = jetfighterCol;

                switch (command)
                {
                    case "up":
                        nextRow--;
                        break;
                    case "down":
                        nextRow++;
                        break;
                    case "left":
                        nextCol--;
                        break;
                    case "right":
                        nextCol++;
                        break;
                }

                if (!IsInside(airspace, nextRow, nextCol))
                {
                    continue;
                }

                char nextPosition = airspace[nextRow, nextCol];

                airspace[jetfighterRow, jetfighterCol] = '-';
                airspace[nextRow, nextCol] = 'J';
                jetfighterRow = nextRow;
                jetfighterCol = nextCol;

                if (nextPosition == 'E')
                {
                    enemyPlanesCount--;
                    if (enemyPlanesCount == 0)
                    {
                        missionAccomplished = true;
                        break;
                    }
                    else
                    {
                        armor -= 100;
                        if (armor <= 0)
                        {
                            missionFailed = true;
                            break;
                        }
                    }
                }
                else if (nextPosition == 'R')
                {
                    armor = 300;
                }
            }

            if (missionAccomplished)
            {
                Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
            }
            else if (missionFailed)
            {
                Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jetfighterRow}, {jetfighterCol}]!");
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(airspace[row, col]);
                }
                Console.WriteLine();
            }
        }

        static bool IsInside(char[,] airspace, int row, int col)
        {
            return row >= 0 && row < airspace.GetLength(0) && col >= 0 && col < airspace.GetLength(1);
        }
    }
}
