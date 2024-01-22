namespace LineNumbers
{
    using System;
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            string output = "";

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int totalChars = line.Length;
                int punctuationCount = 0;
                foreach (char c in line)
                {
                    if (char.IsPunctuation(c))
                    {
                        punctuationCount++;
                    }
                }
                output += $"Line {i + 1}: {line} ({totalChars - punctuationCount})({punctuationCount})\n";
            }

            File.WriteAllText(outputFilePath, output);
        }
    }
}