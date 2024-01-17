namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main()
        {
            HashSet<string> parking = new HashSet<string>();

            string input = null;
            while((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(", ");

                if(command[0] == "IN")
                {
                    parking.Add(command[1]);
                }
                else
                {
                    parking.Remove(command[1]);
                }
            }

            if (parking.Count > 0)
            {
                Console.WriteLine(string.Join("\n", parking));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
