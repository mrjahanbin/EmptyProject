using System.Collections.Generic;

namespace EmptyConsole5.Domains
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }


        public virtual ICollection<BookAuthor> BookAuthors { get; set; }

    }
}



