namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main()
        {
            List<string> names = Console.ReadLine().Split().ToList();

            string input = null;
            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] command = input.Split(" ");

                switch (command[0])
                {
                    case "Remove":
                        switch (command[1])
                        {
                            case "StartsWith":
                                names = names.Where(g => !g.StartsWith(command[2])).ToList();
                                break;
                            case "EndsWith":
                                names = names.Where(g => !g.EndsWith(command[2])).ToList();
                                break;
                            case "Length":
                                int length = int.Parse(command[2]);
                                names = names.Where(g => g.Length != length).ToList();
                                break;
                        }
                        break;
                    case "Double":
                        switch (command[1])
                        {
                            case "StartsWith":
                                names.AddRange(names.Where(g => g.StartsWith(command[2])).ToList());
                                break;
                            case "EndsWith":
                                names.AddRange(names.Where(g => g.EndsWith(command[2])).ToList());
                                break;
                            case "Length":
                                 int length = int.Parse(command[2]);
                                names.AddRange(names.Where(g => g.Length == length).ToList());
                                break;
                        }
                        break;
                }
            }
            if (names.Any())
            {
                Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
