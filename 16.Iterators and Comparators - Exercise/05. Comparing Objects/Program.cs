namespace Comparing_Objects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new();

            string input = string.Empty;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] personDetails = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = personDetails[0];
                int year = int.Parse(personDetails[1]);
                string town = personDetails[2];

                Person person = new(name, year, town);
                people.Add(person);
            }

            int indexOfComparedPerson = int.Parse(Console.ReadLine());
            Person personToCompare = people[indexOfComparedPerson - 1];

            int equalCount = 0;
            int differentCount = 0;
            foreach (Person person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equalCount++;
                }
                else
                {
                    differentCount++;
                }
            }

            if (equalCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                differentCount = people.Count - equalCount;
                Console.WriteLine($"{equalCount} {differentCount} {people.Count}");
            }
        }
    }
}