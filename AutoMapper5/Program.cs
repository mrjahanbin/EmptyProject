using AutoMapper;
using AutoMapper5.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMapper5
{
    internal class Program : ProgramBase
    {
        static async Task Main(string[] args)
        {
            var _DBContext = StartDb();
            var Book = await _DBContext.Books.FirstOrDefaultAsync();
            var Books = await _DBContext.Books.ToListAsync();
            var BookAuthors = await _DBContext.BookAuthors
                .Include(x => x.Book)
                .Include(x => x.Author)
                .ToListAsync();

            //تعاریف اولیه AutoMapper
            var config = new MapperConfiguration(x =>
            {
                //x.CreateMap<Book, Book2>().ReverseMap();
                //x.CreateMap<List<Book>, List<Book2>>().ReverseMap();
                //x.CreateMap<List<Book>, Book2>().ReverseMap();
                //x.CreateMap<Book, List<Book2>>().ReverseMap();


                //x.CreateMap<BookAuthor, BookAuthor2>().ReverseMap();
                //x.CreateMap<BookAuthor, BookAuthor3>().ReverseMap();
                //x.CreateMap<BookAuthor, BookAuthor4>().ReverseMap();
                //x.CreateMap<BookAuthor, BookAuthor5>().ReverseMap();
                //x.CreateMap<BookAuthor, BookAuthor6>().ReverseMap();
                //x.CreateMap<BookAuthor, BookAuthor6>()
                //.ForMember(x => x.BookAuthorid, y => y.MapFrom(z => z.id))
                //.ForMember(x => x.BookOrgId, y => y.MapFrom(z => z.BookId))
                //.ForMember(x => x.AuthorOrgId, y => y.MapFrom(z => z.AuthorId))
                //.ReverseMap();

                x.CreateMap<BookAuthor, BookAuthor7>()
                .ForMember(x => x.BookAuthorid, y => y.MapFrom(z => z.id))
                .ForMember(x => x.BookOrgId, y => y.MapFrom(z => z.BookId))
                .ForMember(x => x.AuthorOrgId, y => y.MapFrom(z => z.AuthorId))
                .ReverseMap();

            });
            IMapper mapper = config.CreateMapper();


            #region تکی
            //تبدیل یک مدل به مدل دیگه
            //var mapper2 = mapper.Map<Book2>(Book);
            #endregion

            #region لیست
            //تبدیل یک لیست به لیست دیگه
            //بدون نیاز به تعریف مپ جدید انجام شد
            //تعریف قبلیش به شکل زیر هستش
            //x.CreateMap<Book, Book2>().ReverseMap();
            //var mappers = mapper.Map<List<Book2>>(Books);

            //تبدیل یک لیست به لیست دیگه
            //با تعریف مپ جدید به شکل زیر خطا خورد
            //x.CreateMap<List<Book>, List<Book2>>().ReverseMap();
            //var mappers = mapper.Map<List<Book2>>(Books);

            //تبدیل یک لیست به لیست دیگه
            //با تعریف مپ جدید به شکل زیر خطا خورد
            //x.CreateMap<List<Book>, Book2>().ReverseMap();
            //var mappers = mapper.Map<List<Book2>>(Books);

            //تبدیل یک لیست به لیست دیگه
            //با تعریف مپ جدید به شکل زیر خطا خورد
            //x.CreateMap<Book, List<Book2>>().ReverseMap();
            //var mappers = mapper.Map<List<Book2>>(Books);
            #endregion

            #region مجموعه لیست
            //تبدیل یک لیست به لیست دیگه
            //بدون نیاز به تعریف مپ جدید انجام شد
            //تعریف قبلیش به شکل زیر هستش
            //x.CreateMap<BookAuthor, BookAuthor2>().ReverseMap();
            //var mappers = mapper.Map<List<BookAuthor2>>(BookAuthors);

            //تبدیل یک لیست به لیست دیگه
            //بدون نیاز به تعریف مپ جدید انجام شد
            //تعریف قبلیش به شکل زیر هستش
            //x.CreateMap<BookAuthor, BookAuthor2>().ReverseMap();
            //var mappers = mapper.Map<List<BookAuthor3>>(BookAuthors);

            //تبدیل یک لیست به لیست دیگه
            //بدون نیاز به تعریف مپ جدید انجام شد
            //تعریف قبلیش به شکل زیر هستش
            //x.CreateMap<BookAuthor, BookAuthor2>().ReverseMap();
            //var mappers = mapper.Map<List<BookAuthor4>>(BookAuthors);

            //تبدیل یک لیست به لیست دیگه
            //بدون نیاز به تعریف مپ جدید انجام شد
            //تعریف قبلیش به شکل زیر هستش
            //x.CreateMap<BookAuthor, BookAuthor2>().ReverseMap();
            //بافیلدی که توی مدل اصلی نیست کاری نداره و مپ رو بخوبی انجام میده
            //var mappers = mapper.Map<List<BookAuthor5>>(BookAuthors);

            //تبدیل یک لیست به لیست دیگه
            //تعریف قبلیش به شکل زیر هستش
            //خطا نداد ولی مپ هم نکرد
            //x.CreateMap<BookAuthor, BookAuthor6>().ReverseMap();
            //var mappers = mapper.Map<List<BookAuthor6>>(BookAuthors);

            //تبدیل یک لیست به لیست دیگه
            //تعریف قبلیش به شکل زیر هستش
            //با تعریف مپ جدید انجام شد
            // x.CreateMap<BookAuthor, BookAuthor6>()
            //.ForMember(x => x.BookAuthorid, y => y.MapFrom(z => z.id))
            //.ForMember(x => x.BookOrgId, y => y.MapFrom(z => z.BookId))
            //.ForMember(x => x.AuthorOrgId, y => y.MapFrom(z => z.AuthorId))
            //.ReverseMap();
            //var mappers = mapper.Map<List<BookAuthor6>>(BookAuthors);


            //تبدیل یک لیست به لیست دیگه
            //تعریف قبلیش به شکل زیر هستش
            //با تعریف مپ جدید انجام شد
            // x.CreateMap<BookAuthor, BookAuthor6>()
            //.ForMember(x => x.BookAuthorid, y => y.MapFrom(z => z.id))
            //.ForMember(x => x.BookOrgId, y => y.MapFrom(z => z.BookId))
            //.ForMember(x => x.AuthorOrgId, y => y.MapFrom(z => z.AuthorId))
            //.ReverseMap();
            var mappers = mapper.Map<List<BookAuthor7>>(BookAuthors);
            #endregion

            Console.WriteLine("Hello World!");
        }
    }
}
