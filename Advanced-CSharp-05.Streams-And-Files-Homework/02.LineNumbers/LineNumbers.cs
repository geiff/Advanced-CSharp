using System;
using System.IO;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader("../../linenumbers.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../newtext.txt"))
                {
                    string line = reader.ReadLine();
                    Int16 lineNumber = 1;
                    while (line != null)
                    {
                        string lineNum = lineNumber + ". " +  line;

                        writer.WriteLine(lineNum);
                        lineNumber++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
