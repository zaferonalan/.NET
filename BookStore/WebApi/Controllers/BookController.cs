using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.AddControllers {

    [ApiController]
    [Route("[controller]s")]
    public class BookController :ControllerBase
    {
        private static List<Book> BookList = new List<Book>()
        {
            new Book{
                Id = 1,
                Title = "Lean Startup", // Personel Growht
                GenreId = 1,
                PageCount = 200,
                PublishDate = new DateTime(2001,06,12)
            },

            new Book{
                Id = 2,
                Title = "Herland", // Science Fiction
                GenreId = 2,
                PageCount = 250,
                PublishDate = new DateTime(2010,05,23)
            },

            new Book{
                Id = 3,
                Title = "Dune", // Science Fiction
                GenreId = 2,
                PageCount = 540,
                PublishDate = new DateTime(2001,12,21)
            }
        };

        // Burda root'tan aldık bilgileri
        [HttpGet]
        public List<Book> GetBooks()
        {
            var bookList = BookList.OrderBy(x=>x.Id).ToList<Book>();
            return bookList;
        }

        // root'tan idleri çağırdık 
        [HttpGet ("{id}")]
        public Book GetById(int id)
        {
            var book = BookList.Where(book => book.Id == id).SingleOrDefault();
            return book;
        }


        // query ile getirdik ama id için roote daha mantıklı
        // [HttpGet]
        // public Book Get([FromQuery] string id)
        // {
        //     var book = BookList.Where(book => book.Id == Convert.ToInt32(id)).SingleOrDefault();
        //     return book;
        // }
    }
}