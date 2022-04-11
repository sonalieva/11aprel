using System;
using ClassLibrary;

namespace _11aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nece book obyekti yaratmaq isdeyirsiniz?");
            int count = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            string bookname;
            string authorname;
            string genre;
            int price;
            string pricestr;
            int genretype;
            


            do
            {
                Console.WriteLine($"{i + 1}.Kitabin adini daxl edin");
                bookname = Console.ReadLine();


            } while (string.IsNullOrEmpty(bookname));
            do
            {
                Console.WriteLine($"{i + 1}.Yazicinin adini daxl edin");
                authorname = Console.ReadLine();

            } while (string.IsNullOrEmpty(authorname));
            do
            {
                Console.WriteLine($"{i + 1}.Kitabin janrini daxl edin");
                genre = Console.ReadLine();

            } while (string.IsNullOrEmpty(genre));
            do
            {
                Console.WriteLine($"{i + 1}.Kitabin qiymetini daxl edin");
                price = Convert.ToInt32(Console.ReadLine());
            } while (!int.TryParse(pricestr, out price));
            Book book = new Book();
            book.Name = bookname;
            foreach (var item in Enum.GetValues(typeof(GenreBookType)))
            {
                if ((int)item == genretype)
                {
                    book.Genre = (GenreBookType)item;
                }
            }

            book.Price = price;
            book.AuthorName = authorname;
            Library library = new Library();

            library.Books.Add(book);
            foreach (var item in library.Books)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("==========Filter by Genre==========");
            foreach (var item in library.FilterByGenre(GenreBookType.Comedy))
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("==========Filter by Price==========");
            foreach (var item in library.FilterByPrice(34,94))
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("==========Filter by No==========");
            Console.WriteLine(library.FindBookByNo(1).Name);

            Console.WriteLine("==========Is Exist by No==========");
            Console.WriteLine(library.IsExistBookByNo(2));

        }
    }
}
