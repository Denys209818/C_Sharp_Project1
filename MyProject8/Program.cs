using MyProject8.Classes;
using System;
using System.Text;

namespace MyProject8
{
    class Program
    {
         //     Создать примитивный англо-русский и русско-английский словарь, содержащий пары слов — названий
         //     стран на русском и английском языках.Пользователь
         //     должен иметь возможность выбирать направление перевода и запрашивать перевод.
        static void Main()
        {
            /*
             *  Записаний набір слів
             *  Киев - Kiev
             *  Варшава - Warszawa
             *  Рим - Rome
             *  Париж - Paris
             *  Берлин - Berlin
             */
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            DictionaryMenu.Menu();

        }
    }
}
