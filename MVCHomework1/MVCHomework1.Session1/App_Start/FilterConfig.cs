﻿using System.Web;
using System.Web.Mvc;

namespace MVCHomework1.Session1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
