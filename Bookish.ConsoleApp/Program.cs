using System;
using System.Linq;
using Bookish.DataAccess;

namespace Bookish.ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            BookRepository br = new BookRepository();

            foreach (User user in br.GetAllUsersWithSpecifiedSurname("Bevan"))
            {
                Console.WriteLine(user);
            }

            Console.WriteLine();

            //br.AddBookToLibrary("A Book Title", "Your mum", "isbn123456", "barcode123456", 69);

            foreach (Book book in br.GetAllBooks())
            {
                Console.WriteLine(book);
            }
        }
    }
}
