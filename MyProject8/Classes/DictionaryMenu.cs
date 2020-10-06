using MyProject8.Classes;
using System;
using System.Text;

namespace MyProject8
{
    static class DictionaryMenu
    {
        static bool flag = false;
        static Dictionary myDictionary;

        public static void Start()
        {
            DictionaryMenu.myDictionary = new Dictionary();
            DictionaryMenu.myDictionary.PushToDictionary("Киев", "Kiev");
            DictionaryMenu.myDictionary.PushToDictionary("Варшава", "Warszawa");
            DictionaryMenu.myDictionary.PushToDictionary("Берлин", "Berlin");
            DictionaryMenu.myDictionary.PushToDictionary("Рим", "Rome");
            DictionaryMenu.myDictionary.PushToDictionary("Париж", "Paris");
            DictionaryMenu.flag = true;
        }

        public static void Menu() 
        {
            if (!DictionaryMenu.flag) 
            {
                DictionaryMenu.Start();
            }

                string lang = "";
            while (true) 
            {
                Console.Clear();
                if (!DictionaryMenu.myDictionary.GetMode())
                {
                    lang = "Руский";
                }
                else
                {
                    lang = "Английский";
                }

                Console.WriteLine($"Мова вводу - {lang}. Змінити введіть yes чи no - ");
                string res = Console.ReadLine();
                if (res == "yes")
                {
                    DictionaryMenu.myDictionary.ChangeMode();
                    lang = lang == "Руский" ? lang = "Английский" : lang = "Руский";
                }
                Console.Clear();

                string word = "";
                Console.Write($"Введіть назву міста ({lang}) - ");
                word = Console.ReadLine();

                string translate = DictionaryMenu.myDictionary.GetTranslate(word);
                Console.WriteLine(translate);
                Console.ReadKey();
            }
        }
    }
}
