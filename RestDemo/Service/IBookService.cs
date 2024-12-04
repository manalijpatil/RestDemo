using RestDemo.Model;

namespace RestDemo.Service
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book GetBookById(int id);
        IEnumerable<Book> GetBookByAuthor(string author);
        int AddBook(Book Books);
        int UpdateBook(Book Books);
        int DeleteBook(int id);
    }
}
