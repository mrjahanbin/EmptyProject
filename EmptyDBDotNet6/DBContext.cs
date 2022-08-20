using EmptyDBDotNet6.Domains;
using Microsoft.EntityFrameworkCore;

namespace EmptyDBDotNet6
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Book> Books { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {

            }

        }


    }
}
