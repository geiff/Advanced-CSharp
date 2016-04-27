using System;
using System.IO;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader("../../oddline.txt"))
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    lineNumber += 2;
                    reader.ReadLine();
                    line = reader.ReadLine();
                }
            }
        }
    }
}