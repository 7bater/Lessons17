//using Lessons17;
//using System;
//using System.Text;
//using static System.Console;

//namespace Lessons17
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            string filePath = @"C:\Users\kozer\c#\Lessons17\file_data\magazine.json";
//            MagazineManager manager = new MagazineManager(filePath);

//            Magazine myMagazine = new Magazine("IT World", "Danya Team", "2026-11-20", 72);
//            myMagazine.Articles.Add(new Article("Сучасний C#", 2800, "Огляд нових можливостей мови програмування C#."));
//            myMagazine.Articles.Add(new Article("Архітектура System.IO", 1900, "Правильна робота з файлами та потоками."));

//            WriteLine("\n1. Введення та виведення початкової інформації:");
//            myMagazine.Display();

//            WriteLine("\n2. Серіалізація та збереження у файл JSON:");
//            manager.SaveToJson(myMagazine);

//            WriteLine("\n3. Завантаження та десереалізація з файлу:");
//            Magazine loadedMagazine = manager.LoadFromJson();

//            if (loadedMagazine != null)
//            {
//                WriteLine("\n4. Виведення завантажених даних:");
//                loadedMagazine.Display();
//            }

//            ReadKey();
//        }
//    }
//}

//xml
using Lessons17;
using System;
using System.Text;
using static System.Console;

namespace Lessons17
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;

            string filePath = @"C:\Users\kozer\c#\Lessons17\file_data\magazines.xml";
            MagazineManager manager = new MagazineManager(filePath);

            Magazine mag1 = new Magazine("IT World", "Danya Team", "2026-11-20", 72);
            mag1.Articles.Add(new Article("Сучасний C#", 2800, "Огляд нових можливостей мови програмування C#."));
            mag1.Articles.Add(new Article("Архітектура System.IO", 1900, "Правильна робота з файлами та потоками."));

            Magazine mag2 = new Magazine("Science & Tech", "Global Press", "2026-11-20", 48);
            mag2.Articles.Add(new Article("Штучний інтелект", 3200, "Майбутнє нейромереж та їх застосування."));

            Magazine[] magazines = new Magazine[] { mag1, mag2 };

            WriteLine("\n1. Виведення початкового масиву журналів:");
            foreach (var mag in magazines)
            {
                mag.Display();
            }

            WriteLine("\n2. Серіалізація в XML та збереження у файл:");
            manager.SaveToXml(magazines);

            WriteLine("\n3. Завантаження та десереалізація з XML-файлу:");
            Magazine[] loadedMagazines = manager.LoadFromXml();

            if (loadedMagazines != null)
            {
                WriteLine("\n4. Виведення завантажених даних:");
                foreach (var mag in loadedMagazines)
                {
                    mag.Display();
                }
            }

            ReadKey();
        }
    }
}