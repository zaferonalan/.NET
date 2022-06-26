using System;

namespace WebApi
{
    public class Book{

        public int Id {get;set;}
        public string Title { get; set; }
        public int GenreId { get; set; } // Kitabın türü

        public int PageCount { get; set; } // Sayfa Sayısı

        public DateTime PublishDate { get; set; }
     }
}