using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf(4);
            bookShelf.appendBook(new Book("Around the World in 80 Days"));
            bookShelf.appendBook(new Book("Bible"));
            bookShelf.appendBook(new Book("Cinderella"));
            bookShelf.appendBook(new Book("Daddy-Long-Legs"));
            Iterator it = bookShelf.Iterator();
            while (it.hasNext())
            {
                Book book = (Book)it.next();
                Console.WriteLine(book.title);
            }

        }
    }
}
