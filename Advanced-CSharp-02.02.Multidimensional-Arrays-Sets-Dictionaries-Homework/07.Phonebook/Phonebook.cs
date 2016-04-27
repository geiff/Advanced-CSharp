using System;
using System.Collections.Generic;

namespace _07.Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            string inputIformation = Console.ReadLine();
            Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();

            while (inputIformation != "search")
            {
                string[] inputArr = inputIformation.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputArr[0];
                string contacts = inputArr[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, new List<string>());
                }

                phonebook[name].Add(contacts);

                inputIformation = Console.ReadLine();
            }

            string inputSearch = Console.ReadLine();
            while (!string.IsNullOrEmpty(inputSearch))
            {
                if (phonebook.ContainsKey(inputSearch))
                {
                    Console.WriteLine("{0} --> {1}", inputSearch, string.Join("; ", phonebook[inputSearch]));
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", inputSearch);
                }

                inputSearch = Console.ReadLine();
            }
        }
    }
}
