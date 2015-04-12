using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework.MVC._1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home2
        public ActionResult Glavna()
        {
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);
            ViewBag.lista = lista;
            return View();
        }
        public ActionResult Strana1()
        {
            List<string> lista2 = new List<string>();
            lista2.Add("Dzek");
            lista2.Add("Dzordz");
            lista2.Add("Dzekson");
            lista2.Add("Dzonson");
            lista2.Add("Dzon");
            
            return View(lista2);
        }
        public ViewResult About()
        {
            return View();
        }
    }
}