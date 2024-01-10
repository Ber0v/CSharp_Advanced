namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();

            int passed = 0;
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < N; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passed ++;
                        }
                    }
                    continue;
                }
                cars.Enqueue(command);
            }
            Console.WriteLine($"{passed} cars passed the crossroads.");
        }
    }
}
