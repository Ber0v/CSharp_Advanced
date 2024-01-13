namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] Jagg = new int[rows][];

            for (int row = 0; row < Jagg.Length; row++)
            {
                Jagg[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string command = "";
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] splitted = command.Split(' ');

                int row = int.Parse(splitted[1]);
                int col = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);

                if (row < 0 || row >= Jagg.Length || Jagg[row].Length <= col || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (splitted[0] == "add")
                {
                    Jagg[row][col] += value;
                }
                else if (splitted[0] == "subtract")
                {
                    Jagg[row][col] -= value;
                }
            }

            foreach (var row in Jagg)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
