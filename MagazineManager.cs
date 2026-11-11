//using Lessons17;
//using System;
//using System.IO;
//using System.Text.Json;

//namespace Lessons17
//{
//    public class MagazineManager
//    {
//        private string FilePath { get; set; }

//        public MagazineManager(string filePath)
//        {
//            FilePath = filePath;
//        }

//        public void SaveToJson(Magazine magazine)
//        {
//            try
//            {
//                string dir = Path.GetDirectoryName(FilePath);
//                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
//                {
//                    Directory.CreateDirectory(dir);
//                }

//                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
//                string jsonString = JsonSerializer.Serialize(magazine, options);

//                File.WriteAllText(FilePath, jsonString);
//                Console.WriteLine($"Успіх: Журнал успішно серіалізовано та збережено до \"{FilePath}\".");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Помилка під час збереження: {ex.Message}");
//            }
//        }

//        public Magazine LoadFromJson()
//        {
//            try
//            {
//                if (!File.Exists(FilePath))
//                {
//                    Console.WriteLine($"Помилка: Файл за шляхом \"{FilePath}\" не знайдено.");
//                    return null;
//                }

//                string jsonString = File.ReadAllText(FilePath);
//                Magazine magazine = JsonSerializer.Deserialize<Magazine>(jsonString);
//                Console.WriteLine("Успіх: Журнал успішно завантажено та десереалізовано з файлу.");
//                return magazine;
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Помилка під час завантаження: {ex.Message}");
//                return null;
//            }
//        }
//    }
//}

//xml
using System;
using System.IO;
using System.Xml.Serialization;

namespace Lessons17
{
    public class MagazineManager
    {
        private string FilePath { get; set; }

        public MagazineManager(string filePath)
        {
            FilePath = filePath;
        }

        public void SaveToXml(Magazine[] magazines)
        {
            try
            {
                string dir = Path.GetDirectoryName(FilePath);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(Magazine[]));
                using (FileStream writer = new FileStream(FilePath, FileMode.Create))
                {
                    serializer.Serialize(writer, magazines);
                }

                Console.WriteLine($"Успіх: Масив журналів успішно серіалізовано в XML та збережено до \"{FilePath}\".");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка під час збереження: {ex.Message}");
            }
        }

        public Magazine[] LoadFromXml()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    Console.WriteLine($"Помилка: Файл за шляхом \"{FilePath}\" не знайдено.");
                    return null;
                }

                XmlSerializer serializer = new XmlSerializer(typeof(Magazine[]));
                Magazine[] magazines;
                using (FileStream reader = new FileStream(FilePath, FileMode.Open))
                {
                    magazines = serializer.Deserialize(reader) as Magazine[];
                }

                Console.WriteLine("Успіх: Масив журналів успішно завантажено та десереалізовано з XML.");
                return magazines;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка під час завантаження: {ex.Message}");
                return null;
            }
        }
    }
}