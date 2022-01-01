namespace Domains
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }


        public virtual ICollection<BookAuthor> BookAuthors { get; set; }

    }
}



