namespace CopyBinaryFile
{
    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            const int bufferSize = 1024;
            byte[] buffer = new byte[bufferSize];
            using (FileStream source = new FileStream (inputFilePath, FileMode.Open))
            {
                using ( FileStream destination = new FileStream (outputFilePath, FileMode.Create))
                {
                    int bytesRead;
                    while ((bytesRead = source.Read(buffer, 0, bufferSize)) > 0)
                    {
                        destination.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}
