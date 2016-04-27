using System;

namespace _04.TextFilter
{
    class TextFilter
    {
        static void Main()
        {
            string wordsStringInput = Console.ReadLine();
            string[] word = wordsStringInput.Split(new [] {' ', ',', ';'}, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int indexWordArr = 0; indexWordArr < word.Length; indexWordArr++)
            {
                text = text.Replace(word[indexWordArr], new string('*', word[indexWordArr].Length));
            }

            Console.WriteLine(text);
        }
    }
}
