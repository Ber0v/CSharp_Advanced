namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main()
        {
            List<string> nmaes = new List<string>(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            List<string> filters = new List<string>();

            string input = Console.ReadLine();

            while (input != "Print")
            {

                var commands = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Add filter")
                {
                    filters.Add(commands[1] + " " + commands[2]);
                }
                else if (commands[0] == "Remove filter")
                {
                    filters.Remove(commands[1] + " " + commands[2]);
                }

                input = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                var commands = filter.Split(' ');

                if (commands[0] == "Starts")
                {
                    nmaes = nmaes.Where(p => !p.StartsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Ends")
                {
                    nmaes = nmaes.Where(p => !p.EndsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Length")
                {
                    nmaes = nmaes.Where(p => p.Length != int.Parse(commands[1])).ToList();
                }
                else if (commands[0] == "Contains")
                {
                    nmaes = nmaes.Where(p => !p.Contains(commands[1])).ToList();
                }
            }

            if (nmaes.Any())
            {
                Console.WriteLine(string.Join(" ", nmaes));
            }
        }
    }
}
