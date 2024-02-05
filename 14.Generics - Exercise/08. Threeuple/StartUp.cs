namespace _07._Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            Threeuple<string, string, string> threeuple1 = new Threeuple<string, string, string>(input1[0] + " " + input1[1], input1[2], input1[3]);
            Console.WriteLine($"{threeuple1.Item1} -> {threeuple1.Item2} -> {threeuple1.Item3}");

            string[] input2 = Console.ReadLine().Split();
            bool isDrunk = input2[2] == "drunk";
            Threeuple<string, int, bool> threeuple2 = new Threeuple<string, int, bool>(input2[0], int.Parse(input2[1]), isDrunk);
            Console.WriteLine($"{threeuple2.Item1} -> {threeuple2.Item2} -> {threeuple2.Item3}");

            string[] input3 = Console.ReadLine().Split();
            Threeuple<string, double, string> threeuple3 = new Threeuple<string, double, string>(input3[0], double.Parse(input3[1]), input3[2]);
            Console.WriteLine($"{threeuple3.Item1} -> {threeuple3.Item2} -> {threeuple3.Item3}");
        }
    }
}

