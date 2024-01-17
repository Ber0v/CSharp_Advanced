namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (grades.ContainsKey(name))
                {
                    grades[name].Add(grade);
                }
                else
                {
                    grades.Add(name, new List<decimal>() { grade });
                }
            }

            foreach (var studentGrades in grades)
            {
                decimal sum = 0;
                int time = 0;
                Console.Write($"{studentGrades.Key} -> ");

                foreach (var grade in studentGrades.Value)
                {
                    Console.Write($"{grade:F2} ");
                    sum += grade;
                    time++;
                }

                Console.WriteLine($"(avg: {(sum / time):F2})");
            }
        }
    }
}
