using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EmptyConsole5
{
    internal class Program : ProgramBase
    {
        static async Task Main(string[] args)
        {
            var _DBContext = StartDb();
            var Book = await _DBContext.Books.ToListAsync();


            Console.WriteLine("Hello World!");
        }
    }
}
