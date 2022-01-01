// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using static EmptyConsole6.ProgramBase;
var _DBContext = StartDb();
var Book = await _DBContext.Books.ToListAsync();
Console.WriteLine("Hello, World!");
