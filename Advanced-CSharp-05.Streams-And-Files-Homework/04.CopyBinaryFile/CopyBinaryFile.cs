using System.IO;

namespace _04.CopyBinaryFile
{
    class CopyBinaryFile
    {
        const string ImageFile = "../../cat.png";
        const string ImageResult = "../../copycat.png";

        static void Main()
        {
            using (FileStream sors = new FileStream(ImageFile, FileMode.Open))
            {
                using (FileStream destinaion = new FileStream(ImageResult, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readsByte = sors.Read(buffer, 0, buffer.Length);
                        if (readsByte == 0)
                        {
                            break;
                        }

                        destinaion.Write(buffer, 0, readsByte);
                    }

                }
            }
        }
    }
}