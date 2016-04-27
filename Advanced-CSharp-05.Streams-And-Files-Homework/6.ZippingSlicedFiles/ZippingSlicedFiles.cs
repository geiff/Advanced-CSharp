using System;
using System.IO;
using System.IO.Compression;

namespace _6.ZippingSlicedFiles
{
    class ZippingSlicedFiles
    {
        private const string source = "../../cat.png";
        private const string destination = "../../";

        static void Main()
        {
            Console.Write("Enter in how many parts do you want the file to be sliced: ");
            int parts = int.Parse(Console.ReadLine());

            SliceCompress(source, parts, destination);
            AssembleDecompress(parts);

        }

        static void SliceCompress(string inputFile, int parts, string outputFile)
        {
            byte[] buffer = new byte[4096];
            using (Stream input = File.OpenRead(inputFile))
            {
                int sourcePosition = 1;
                while (input.Position < input.Length)
                {

                    using (Stream outputStream = File.Create(outputFile + "cat_" + sourcePosition + ".gz"))
                    {
                        using (GZipStream compressionStream = new GZipStream(outputStream, CompressionMode.Compress))
                        {
                            int byteCounter = 0;
                            int sizeofEachFile = (int)Math.Ceiling((double)input.Length / parts);

                            while (byteCounter < sizeofEachFile)
                            {
                                int readsByte = input.Read(buffer, 0, buffer.Length);
                                if (readsByte == 0)
                                {
                                    break;
                                }

                                byteCounter += readsByte;
                                compressionStream.Write(buffer, 0, readsByte);
                            }

                        }
                    }

                    sourcePosition++;
                }
            }
        }

        static void AssembleDecompress(int parts)
        {
            byte[] buffer = new byte[4096];
            for (int i = 1; i <= parts; i++)
            {
                string source = String.Format("../../cat_{0}.gz", i);

                using (FileStream partOfFile = new FileStream(source, FileMode.Open))
                {
                    using (var compressionStream = new GZipStream(partOfFile, CompressionMode.Decompress))
                    {
                        using (FileStream assembledFile = new FileStream("../../assembled_cat.png", FileMode.Append))
                        {
                            while (true)
                            {
                                int readBytes = compressionStream.Read(buffer, 0, buffer.Length);
                                if (readBytes == 0)
                                {
                                    break;
                                }

                                assembledFile.Write(buffer, 0, readBytes);
                            }
                        }
                    }
                }
            }
        }
    }
}