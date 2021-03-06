﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCHomework1.Session2.Models
{
    public class MVCHomework1Session2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVCHomework1Session2Context() : base("name=MVCHomework1Session2Context")
        {
        }

        public System.Data.Entity.DbSet<MVCHomework1.Session2.Models.Player> Players { get; set; }
    
    }
}
