using System.ComponentModel.DataAnnotations.Schema;

namespace AutoMapper5.Domains
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
    public class BookAuthor2
    {
        public int id { get; set; }
        public int AuthorId { get; set; }
        public int BookId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }

    }
    public class BookAuthor3
    {
        public int id { get; set; }
        public int AuthorId { get; set; }
        public int BookId { get; set; }

        public Author Author { get; set; }
        public Book Book { get; set; }

    }
    public class BookAuthor4
    {
        public int id { get; set; }
        public int AuthorId { get; set; }
        public int BookId { get; set; }

    }
    public class BookAuthor5
    {
        public int id { get; set; }
        public int AuthorId { get; set; }
        public int BookId { get; set; }
        public string BookEmpty { get; set; }

    }
    public class BookAuthor6
    {
        public int BookAuthorid { get; set; }
        public int AuthorOrgId { get; set; }
        public int BookOrgId { get; set; }

    }
    public class BookAuthor7
    {
        public int BookAuthorid { get; set; }
        public int AuthorOrgId { get; set; }
        public int BookOrgId { get; set; }
        public string BookEmpty { get; set; }

    }
}



