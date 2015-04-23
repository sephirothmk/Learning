using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.CodeAcademy.MVC.BlogSite.Entities
{
    public class BlogPost
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Intro { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Tags { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsPublished { get; set; }
    }
}