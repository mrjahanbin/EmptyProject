namespace EmptyConsole6.Domains
{


    public class Author
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }


    }
}



