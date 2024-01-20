namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long totalSize = 0;
            DirectoryInfo directory = new DirectoryInfo(folderPath);

            FileInfo[] files = directory.GetFiles("*.*", SearchOption.AllDirectories);
            foreach (FileInfo file in files)
            {
                totalSize += file.Length;
            }

            double sizeInKb = totalSize / 1024.0;

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.Write(sizeInKb + " KB");
            }
        }
    }
}
