using RestDemo.Model;
using RestDemo.Repositories;

namespace RestDemo.Service
{
    public class BookService:IBookService
    {
        private readonly IBookRepository repo;
        public BookService(IBookRepository repo) { 
            this.repo = repo;
        }

        public int AddBook(Book Books)
        {
            return repo.AddBook(Books);

        }

        public int DeleteBook(int id)
        {
            return repo.DeleteBook(id);
        }

        public IEnumerable<Book> GetBookByAuthor(string author)
        {
            return repo.GetBookByAuthor(author);
        }

        public Book GetBookById(int id)
        {
            return repo.GetBookById(id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return repo.GetBooks();
        }

        public int UpdateBook(Book book)
        {
            return repo.UpdateBook(book);
        }
    }
}
