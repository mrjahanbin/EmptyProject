using EmptyDBDotNet6.Domains;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmptyDBDotNet6.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DBContext dBContext;

        public IndexModel(ILogger<IndexModel> logger, DBContext dBContext)
        {
            _logger = logger;
            this.dBContext = dBContext;
        }

        public void OnGet()
        {
            //var ss= dBContext.Books.ToList();
            //how to update entity without first loading it
            Book book = new() { Id = 2, Title = "Mohammad Javad Jahanbin" };

            dBContext.Books.Attach(book);
            dBContext.Attach(book).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dBContext.SaveChanges();



        }
    }
}