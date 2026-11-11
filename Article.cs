//using System;

//namespace Lessons17
//{
//    public class Article
//    {
//        public string Title { get; set; }
//        public int CharacterCount { get; set; }
//        public string Announcement { get; set; }

//        public Article() { }

//        public Article(string title, int characterCount, string announcement)
//        {
//            Title = title;
//            CharacterCount = characterCount;
//            Announcement = announcement;
//        }

//        public void DisplayInfo()
//        {
//            Console.WriteLine($"Стаття: \"{Title}\" (Символів: {CharacterCount})");
//            Console.WriteLine($"Анонс: {Announcement}");
//        }
//    }
//}

//xml
using System;

namespace Lessons17
{
    public class Article
    {
        public string Title { get; set; }
        public int CharacterCount { get; set; }
        public string Announcement { get; set; }

        public Article() { }

        public Article(string title, int characterCount, string announcement)
        {
            Title = title;
            CharacterCount = characterCount;
            Announcement = announcement;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Стаття: \"{Title}\" (Символів: {CharacterCount})");
            Console.WriteLine($"Анонс: {Announcement}");
        }
    }
}