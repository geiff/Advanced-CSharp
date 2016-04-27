using System;
using System.IO;

namespace _05.SlicingFile
{
    class SlicingFile
    {
        private const string source = "../../cat.png";
        private const string destination = "../../";

        static void Main()
        {
            Console.Write("Enter in how many parts do you want the file to be sliced: ");
            int parts = int.Parse(Console.ReadLine());

            Slice(parts);
            Assemble(parts);
        }

        static void Slice(int parts)
        {
            byte[] buffer = new byte[4096];
            using (Stream input = File.OpenRead(source))
            {
                int sourcePosition = 1;
                while (input.Position < input.Length)
                {
                    using (Stream output = File.Create(destination + "cat_" + sourcePosition + ".png"))

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
                            output.Write(buffer, 0, readsByte);
                        }
                    }

                    sourcePosition++;
                }
            }
        }

        static void Assemble(int parts)
        {
            byte[] buffer = new byte[4096];
            for (int i = 1; i <= parts; i++)
            {
                string source = String.Format("../../cat_{0}.png", i);

                using (FileStream partOfFile = new FileStream(source, FileMode.Open))
                {
                    using (FileStream assembledFile = new FileStream("../../assembled_cat.png", FileMode.Append))
                    {

                        while (true)
                        {
                            int readsByte = partOfFile.Read(buffer, 0, buffer.Length);
                            if (readsByte == 0)
                            {
                                break;
                            }

                            assembledFile.Write(buffer, 0, readsByte);
                        }
                    }
                }
            }
        }
    }
}