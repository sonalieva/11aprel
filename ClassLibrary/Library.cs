using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Library
    {
        List<Book> Books = new List<Book>();
        public List<Book> FilterByPrice(int minprice,int maxprice)
        {
            List<Book> FilterByPrice = new List<Book>();
            foreach(var item in Books)
            {
                if (item.Price > minprice && item.Price < maxprice)
                    FilterByPrice.Add(item);
               
            }
            return FilterByPrice;

        }
        public List<Book> FilterByGenre(GenreBookType genre)
        {
            List<Book> FilterByGenre = new List<Book>();
            foreach(var item in Books)
            {
                if (item.Genre == genre)
                    FilterByGenre.Add(item);
            }
            return FilterByGenre;

        }
        public Book FindBookByNo(int no)
        {
            foreach(var item in Books)
            {
                if (item.No == no)
                    return item;
            }
            return null;
        }
        public bool IsExistBookByNo(int no)
        {
            foreach(var item in Books)
            {
                if (item.No == no)
                    return true;
            }
            return false;
        }
        public List<Book> RemoveAll(Predicate<Book> predicate)
        {
            List<Book> RemoveAll = new List<Book>();
            foreach(var item in Books)
            {
                if (predicate(item))
                    RemoveAll.Remove(item);
            }
            return Books;
        }

            
    }
}
