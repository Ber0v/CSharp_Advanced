namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
             byte[] bytesToExtract = File.ReadAllLines(bytesFilePath)
                                       .SelectMany(line => line.Split(' '))
                                       .Select(byteString => Convert.ToByte(byteString, 10))
                                       .ToArray();

            using (FileStream input = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream output = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
            {
                int bytesRead;
                byte[] buffer = new byte[4096];

                while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    foreach (byte b in buffer.Take(bytesRead))
                    {
                        if (bytesToExtract.Contains(b))
                        {
                            output.WriteByte(b);
                        }
                    }
                }
            }
        }
    }
}
