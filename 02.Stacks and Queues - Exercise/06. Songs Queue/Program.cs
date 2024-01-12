namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main()
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", ").ToArray());
            
            while (songs.Any())
            {
                string[] command = Console.ReadLine().Split(" ");

                if (command[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if (command[0] == "Add")
                {
                    string songToAdd = string.Join(" ", command.Skip(1));
                    if (songs.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songToAdd);
                    }
                }
                else if(command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
