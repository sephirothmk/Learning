using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCHomework1.Session1.Models;

namespace MVCHomework1.Session1.Controllers
{
    public class BooksController : Controller
    {
        private readonly MVCHomework1Session1Context db = new MVCHomework1Session1Context();

        // GET: Books
        public ActionResult Index()
        {
            return View();
        }
        [Route("books", Name = "Books")]
        public ActionResult Books()
        {
            return View(db.Books.ToList());
        }
       [Route("news", Name = "News")]
        public ActionResult News()
        {
            var news = db.News.OrderByDescending(n => n.DatePosted).Take(5).ToList();
            return View(news);
        }
       public ActionResult CreateNews()
       {
           return View();
       }
       public ActionResult NewsDetails(int? id)
       {
           if (id == null)
           {
               return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
           }
           News news = db.News.Find(id);
           if (news == null)
           {
               return HttpNotFound();
           }
           return View(news);
           
       }

       
       // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
       // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
       [HttpPost]
       [ValidateAntiForgeryToken]
       public ActionResult CreateNews([Bind(Include = "NewsId,NewsContent")] News news)
       {
           if (ModelState.IsValid)
           {
               news.DatePosted = DateTime.Now;
               db.News.Add(news);
               db.SaveChanges();
               return RedirectToAction("News");
           }

           return View(news);
       }



        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookId,PictureUrl,Title,Description,Price,Author")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Books");
            }

            return View(book);
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookId,PictureUrl,Title,Description,Price,Author")] Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Books");
            }
            return View(book);
        }

       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
