namespace EvenLines
{
    using System;
    using System.Text.RegularExpressions;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
             string result = "";
            using (StreamReader sr = new StreamReader(inputFilePath))
            {
                int lineNumber = 0;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (lineNumber % 2 == 0)
                    {
                        line = Regex.Replace(line, @"[-,\.!\?]", "@");
                        string[] words = line.Split(' ');
                        Array.Reverse(words);
                        result += string.Join(" ", words) + Environment.NewLine;
                    }
                    lineNumber++;
                }
            }
            return result.Trim();
        }
    }
}