namespace DirectoryTraversal
{
    using System;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            var extensions = Directory.GetFiles(inputFolderPath)
                .Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                .Distinct()
                .OrderByDescending(ext => Directory.GetFiles(inputFolderPath, $"*.{ext}").Length)
                .ThenBy(ext => ext);

            string reportContent = "";
            foreach (var ext in extensions)
            {
                reportContent += $".{ext}" + Environment.NewLine;
                var files = Directory.GetFiles(inputFolderPath, $"*.{ext}")
                    .Select(file => new FileInfo(file))
                    .OrderBy(file => file.Length)
                    .Select(file => $"--{file.Name} - {file.Length / 1024.0:F3}kb")
                    .ToList();
                reportContent += string.Join(Environment.NewLine, files) + Environment.NewLine;
            }

            return reportContent;
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string reportPath = desktopPath + reportFileName;
            File.WriteAllText(reportPath, textContent);
        }
    }
}
