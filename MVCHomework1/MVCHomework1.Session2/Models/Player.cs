using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCHomework1.Session2.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        [StringLength(5),Required]
        public string Name { get; set; }
        [StringLength(5),Required]
        public string Surname { get; set; }
        [Range(13, 65)]
        public int Age { get; set; }
        public string City { get; set; }
        public bool IsAwesome { get; set; }
    }
}