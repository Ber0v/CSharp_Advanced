namespace _05._Filter_By_Age
{
    internal class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            Person[] people = new Person[lines];

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                people[i] = new Person();
                people[i].Name = input[0];
                people[i].Age = int.Parse(input[1]);

            }

            string filter = Console.ReadLine();
            int filterAge = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> predicate = GetAgeCondition(filter, filterAge);
            Func<Person, string> formatter = GetFormater(format);

            foreach (var person in people)
            {
                if (predicate(person))
                {
                    Console.WriteLine(formatter(person));
                }
            }
        }
        static Func<Person, bool> GetAgeCondition(string filter, int filterAge)
        {
            if (filter == "younger")
            {
                return p => p.Age < filterAge;
            }
            else if (filter == "older")
            {
                return p => p.Age >= filterAge;
            }
            return null;
        }

        static Func<Person, string> GetFormater(string format)
        {
            if (format == "name")
            {
                return p => $"{p.Name}";
            }
            else if (format == "age")
            {
                return p => $"{p.Age}";
            }
            else if (format == "name age")
            {
                return p => $"{p.Name} - {p.Age}";
            }
            return null;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
