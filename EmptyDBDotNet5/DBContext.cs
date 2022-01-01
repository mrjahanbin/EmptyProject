using EmptyDBDotNet5.Domains;
using Microsoft.EntityFrameworkCore;

namespace EmptyDBDotNet5
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<BookAuthor> BookAuthors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {

            }

        }


    }
}
