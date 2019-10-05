using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Book
    {
        public string Name;
        public string Autor;
        public int Year;

    }
    class Program
    {
        static void Main(string[] args)
        {

            var books = new List<Book>()
            {
                new Book() { Name = "Idiot", Year = 1869 },
                new Book() { Name = "LINQ", Year =1956 },
                new Book() { Name = "Vor and Peace", Year = 1745 },
                new Book() { Name = "Finders Keepers", Year = 1980 },
                new Book() { Name = "Guards! Guards!", Year = 1920 }
            };

            //1.

            var bookName = string.Join(",", books.Where(a => a.Name.Contains("LINQ") && (DateTime.IsLeapYear(a.Year))).Select(b => b.Name));
            Console.WriteLine(bookName);

            //2.

            string words = "Output all actors names";

            var wordsCount = string.Join(",", words.Where(a => a != ' ').Distinct().Count());
            Console.WriteLine(wordsCount);

            //3.

            int[] nums = { 23, 56, 15, 26, 48, 78, 43, 19, 71, 52 };

            var sortMas = string.Join(",", nums.OrderBy(a => a / 10).ThenBy(j => j % 10));
            Console.WriteLine(sortMas);

            //4.

            var booksVithAutor = new List<Book>()
            {
                new Book() { Name = "Idiot", Autor = "Dostoevskiy", Year = 1869 },
                new Book() { Name = "LINQ" ,Autor = "Petrov", Year =1956 },
                new Book() { Name = "Vor and Peace", Autor = "Dostoevskiy", Year = 1745 },
                new Book() { Name = "Finders Keepers", Autor = "Stephen King", Year = 1980 },
                new Book() { Name = "Guards! Guards!", Autor = "Terry Pratchett", Year = 1920 }
            };

            
            Console.WriteLine(string.Join("\n", booksVithAutor.GroupBy(a => a.Autor).Select(b => $"{b.Key} {b.Count()}")));






        }
    }
}
