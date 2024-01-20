namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            string[] words = File.ReadAllText(wordsFilePath).ToLower().Split();

            string[] allWords = File.ReadAllText(textFilePath).ToLower().Split(new char[] { ' ', ',', '.', '-', '!', '?', '…' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                int count = allWords.Count(w => w == word);
                wordCounts[word] = count;
            }

            var sortedWordCounts = wordCounts.OrderByDescending(w => w.Value);

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var entry in sortedWordCounts)
                {
                    writer.WriteLine($"{entry.Key} - {entry.Value}");
                }
            }
        }
    }
}