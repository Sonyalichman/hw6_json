using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JSON
{
    public class PublishingHouse
    {
        public int Id { get; }
        public string Name { get; }
        public string Adress { get; }
        public PublishingHouse(int id, string name, string adress)
        {
            Id = id;
            Name = name;
            Adress = adress;
        }
    }
    public class Book
    {

        public int PublishingHouseId { get; }


        public string Title { get; }
        public PublishingHouse PublishingHouse { get; }

        public Book(int publishingHouseId, string title, PublishingHouse publishingHouse)
        {
            PublishingHouseId = publishingHouseId;
            PublishingHouse = publishingHouse;
            Title = title;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string FullFile;
            string FilePath = @"H:\visual\";
            string FileName = "JSOON.json";
            FullFile = FilePath + FileName;
            //Console.WriteLine(TakeFile);
            string FileText = File.ReadAllText(FullFile);

            var books = JsonSerializer.Deserialize<List<Book>>(FileText);

            foreach (var book in books)
            {
                Console.WriteLine(JsonSerializer.Serialize(book));
            }
        }
    }
}
