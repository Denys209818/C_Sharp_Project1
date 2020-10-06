using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject11.Classes
{
   static class WordReader
    {
        private static Dictionary<string, int> dictionary = new Dictionary<string, int>();
        private static string text = "";

        public static void Start() 
        {
            Console.WriteLine("Введіть речення:");
            WordReader.text = Console.ReadLine();

            
            string[] words = WordReader.text.Split(" ");

            for (int i = 0; i < words.Length; i++) 
            {
               words[i] = words[i].Trim(new char[] { '!', '?', ',', '.' });
            }

            for (int i = 0; i < words.Length; i++) 
            {
         
                int counter = 0;

                foreach (var item in words) 
                {
                    if (item == words[i]) 
                    {
                        counter++;
                    }
                }

                if (!WordReader.dictionary.ContainsKey(words[i])) 
                {
                    WordReader.dictionary.Add(words[i], counter);
                }
            }
           


            Console.WriteLine("Кількість повторень кожного слова в реченні:");
            foreach (var item in WordReader.dictionary.Keys) 
            {
                Console.WriteLine(item + " - " + WordReader.dictionary[item]);
            }
        }
    }
}
