//using Lessons17;
//using System;
//using System.Collections.Generic;

//namespace Lessons17
//{
//    public class Magazine
//    {
//        public string Name { get; set; }
//        public string Publisher { get; set; }
//        public string ReleaseDate { get; set; }
//        public int PageCount { get; set; }
//        public List<Article> Articles { get; set; } = new List<Article>();

//        public Magazine() { }

//        public Magazine(string name, string publisher, string releaseDate, int pageCount)
//        {
//            Name = name;
//            Publisher = publisher;
//            ReleaseDate = releaseDate;
//            PageCount = pageCount;
//        }

//        public void Display()
//        {
//            Console.WriteLine("Інформація про журнал");
//            Console.WriteLine($"Назва журналу: {Name}");
//            Console.WriteLine($"Видавництво: {Publisher}");
//            Console.WriteLine($"Дата випуску: {ReleaseDate}");
//            Console.WriteLine($"Кількість сторінок: {PageCount}");
//            Console.WriteLine($"Список статей ({Articles.Count}):");

//            foreach (var article in Articles)
//            {
//                article.DisplayInfo();
//            }
//            Console.WriteLine("");
//        }
//    }
//}

//xml
using Lessons17;
using System;
using System.Collections.Generic;

namespace Lessons17
{
    public class Magazine
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public int PageCount { get; set; }
        public List<Article> Articles { get; set; } = new List<Article>();

        public Magazine() { }

        public Magazine(string name, string publisher, string releaseDate, int pageCount)
        {
            Name = name;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            PageCount = pageCount;
        }

        public void Display()
        {
            Console.WriteLine("інформація про журнал");
            Console.WriteLine($"Назва журналу: {Name}");
            Console.WriteLine($"Видавництво: {Publisher}");
            Console.WriteLine($"Дата випуску: {ReleaseDate}");
            Console.WriteLine($"Кількість сторінок: {PageCount}");
            Console.WriteLine($"Список статей ({Articles.Count}):");

            foreach (var article in Articles)
            {
                article.DisplayInfo();
            }
        }
    }
}