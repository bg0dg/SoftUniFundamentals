using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace _06._Book_Library_Modification
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }

        //   public Book() //Това е default-ен конструктор
        //   {
        //
        //   }

        public Book(string title, string autor, string publisher, DateTime releaseDate, string isbn, decimal price) //конструктор с параметри
        {
            Title = title;
            Author = autor;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            Isbn = isbn;
            Price = price;
        }
    }

    class Library
    {
        public string LibraryName { get; set; }
        public List<Book> Books { get; set; }

        public Library(string libraryName)
        {
            LibraryName = libraryName;
            Books = new List<Book>();
        }

        public void addBook(Book book)
        {
            Books.Add(book);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int bookCount = int.Parse(Console.ReadLine());

            Library library = new Library("MyLibrary");

            while (bookCount-- > 0)
            {
                string[] bookInput = Console.ReadLine().Split();

                string title = bookInput[0];
                string autor = bookInput[1];
                string publisher = bookInput[2];
                DateTime releaseDate = DateTime.ParseExact(bookInput[3], "dd.MM.yyyy", CultureInfo.InstalledUICulture);
                string isbn = bookInput[4];
                decimal price = decimal.Parse(bookInput[5]);

                //Book book = new Book(); //Така се сетва при default-ен конструктор
                //book.Title = title;
                // ....

                Book book = new Book(title, autor, publisher, releaseDate, isbn, price); //Първоначално инициализиране

                library.addBook(book);
            }

            DateTime checkDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InstalledUICulture);

            library.Books.Where(d => d.ReleaseDate > checkDate).OrderBy(d => d.ReleaseDate).ThenBy(t => t.Title)
                .ToList().ForEach(b =>
                {
                    Console.WriteLine($"{b.Title} -> {b.ReleaseDate:dd.MM.yyyy}");
                });

        }
    }
}
