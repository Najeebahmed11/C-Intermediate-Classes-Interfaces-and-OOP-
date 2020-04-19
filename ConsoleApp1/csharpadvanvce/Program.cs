
using System;

namespace csharpadvanvce
{
    class Program
    {
        //Lambda expression: a annoynyms method 
        //no access modifier
        //no name
        //no return statment
        //why do we use it?
        //for convienence,to write less code and achieve same thing
        //args =>(goes to) expression    
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

        }
    }
}
