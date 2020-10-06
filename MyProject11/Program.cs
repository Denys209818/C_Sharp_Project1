using MyProject11.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject11
{
//      Подсчитать, сколько раз каждое слово встречается в заданном тексте.Результат записать в коллекцию
//      Dictionary<TKey, TValue>
    class Program
    {
        
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            WordReader.Start();
        }
    }
}
