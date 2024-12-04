using Microsoft.EntityFrameworkCore;
using RestDemo.Model;

namespace RestDemo.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>op):base(op)
        {
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
