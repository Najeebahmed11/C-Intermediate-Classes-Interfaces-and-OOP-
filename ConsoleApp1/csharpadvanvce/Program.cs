using System;
using System.Collections.Generic;
using System.Linq;

namespace csharpadvanvce
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            books.Where();
            books.Single();
            Book.SingleOrdefault();
            books.First();
            books.FirstOrDefault();
            books.Last();


        }



    }
}
