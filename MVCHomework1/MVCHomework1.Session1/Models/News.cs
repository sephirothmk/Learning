using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomework1.Session1.Models
{
    public class News
    {
        public int NewsId { get; set; }
        public string NewsContent { get; set; }
        public DateTime DatePosted { get; set; }
    }
}