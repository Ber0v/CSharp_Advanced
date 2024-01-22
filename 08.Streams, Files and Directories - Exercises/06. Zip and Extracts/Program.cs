namespace ZipAndExtract
{
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFilePath = "..\\..\\..\\copyMe.png";
            string zipArchiveFilePath = "..\\..\\..\\archive.zip";
            string extractedFileName = "..\\..\\..\\extracted.png";

            ZipFileToArchive(inputFilePath, zipArchiveFilePath);
            ExtractFileFromArchive(zipArchiveFilePath, inputFilePath, extractedFileName);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            using (FileStream zipToCreate = new FileStream(zipArchiveFilePath, FileMode.Create))
            {
                using (ZipArchive archive = new ZipArchive(zipToCreate, ZipArchiveMode.Create))
                {
                    string entryName = Path.GetFileName(inputFilePath);
                    archive.CreateEntryFromFile(inputFilePath, entryName);
                }
            }
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            using (ZipArchive archive = ZipFile.OpenRead(zipArchiveFilePath))
            {
                ZipArchiveEntry entry = archive.GetEntry(fileName);
                entry.ExtractToFile(outputFilePath);
            }
        }
    }
}
