using System.Collections.Generic;

namespace AutoMapper5.Domains
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }


        public virtual ICollection<BookAuthor> BookAuthors { get; set; }

    }

    public class Book2
    {
        public int Id { get; set; }
        public string Title { get; set; }

    }
}



