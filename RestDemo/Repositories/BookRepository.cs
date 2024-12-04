using RestDemo.Data;
using RestDemo.Model;

namespace RestDemo.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext db;
        public BookRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddBook(Book Books)
        {
            int result = 0;
            db.Books?.Add(Books);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteBook(int id)
        {
            int result = 0;
            var bk = db.Books?.Where(x => x.BookId == id).FirstOrDefault();
            if (bk != null)
            {
                db.Books?.Remove(bk);
                result = db.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Book> GetBookByAuthor(string author)
        {
            var model = db.Books?.Where(x => x.Author.Contains(author)).ToList();
            return model;
        }

        public Book GetBookById(int id)
        {
            return db.Books?.Where(x => x.BookId == id).FirstOrDefault();
        }

        public IEnumerable<Book> GetBooks()
        {
            return db.Books.ToList();
        }

        public int UpdateBook(Book Books)
        {
            int result = 0;
            var bk=db.Books?.Where(x=> x.BookId==Books.BookId).FirstOrDefault();
            if (bk != null)
            {
                db.Entry<Book>(bk).CurrentValues.SetValues(Books);
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
