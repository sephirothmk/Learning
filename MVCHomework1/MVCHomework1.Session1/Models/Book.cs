using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomework1.Session1.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string PictureUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
    }
}