using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class BookRepository
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBook(int itemId)
        {
            Book book = books.ElementAt(itemId);
            return book;
        }

        public double GetTotalValue()
        {
            double price = 0;

            foreach (Book book in books)
            {
                price += book.Price;
            }

            return price;

        }
    }
}
