using System.ComponentModel.DataAnnotations.Schema;

namespace EmptyConsole5.Domains
{
    public class BookAuthor
    {
        public int id { get; set; }
        public int AuthorId { get; set; }
        public int BookId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }

    }
}



