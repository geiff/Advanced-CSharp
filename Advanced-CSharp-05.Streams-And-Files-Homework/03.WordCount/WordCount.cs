using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class WordCount
    {
        static void Main()
        {
            List<string> wordsList = new List<string>();
            using (StreamReader readerWords = new StreamReader("../../words.txt"))
            {
                string line = readerWords.ReadLine();
                while (line != null)
                {
                    wordsList.Add(line);
                    line = readerWords.ReadLine();
                }
            }

            List<string> textList = new List<string>();
            using (StreamReader readerText = new StreamReader("../../text.txt"))
            {
                string line = readerText.ReadLine();
                while (line != null)
                {
                    textList.Add(line);
                    line = readerText.ReadLine();
                }
            }


            using (StreamWriter writerResult = new StreamWriter("../../results.txt"))
            {
                Dictionary<string, int> result = new Dictionary<string, int>();
                for (int i = 0; i < wordsList.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < textList.Count; j++)
                    {
                        if (textList[j].ToLower().Contains(wordsList[i]))
                        {
                            count++;
                        }
                    }

                    result.Add(wordsList[i], count);
                }

                var orderResult = result.OrderByDescending(x => x.Value);
                foreach (var str in orderResult)
                {
                    writerResult.WriteLine(str.Key + " - " + str.Value);
                }
            }
        }
    }
}