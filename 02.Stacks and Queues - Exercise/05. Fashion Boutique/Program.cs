namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            int capacity = int.Parse(Console.ReadLine());

            int boxes = 0;
            while (clothes.Count > 1)
            {
                int a = clothes.Pop();
                int b = clothes.Pop();
                if((a + b) <= capacity)
                {
                    
                    clothes.Push(a + b);
                }
                else
                {
                    clothes.Push(b);
                    boxes++;
                }
            }
            boxes++;
            Console.WriteLine(boxes);
        }
    }
}
