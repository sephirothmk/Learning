using SEDC.CodeAcademy.MVC.BlogSite.Entities;
using SEDC.CodeAcademy.MVC.BlogSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SEDC.CodeAcademy.MVC.BlogSite.Controllers
{
    public class BlogController : Controller
    {
        BlogDbContext db = new BlogDbContext();

        // GET: Blog
        public ActionResult Index(string tag)
        {
            if (!string.IsNullOrWhiteSpace(tag))
            {
                var filtered = db.BlogPosts
                            .Where(x => x.Tags.Contains(tag) && x.IsPublished)
                            .OrderByDescending(x => x.DateCreated)
                            .ToList();

                return View(filtered);
            }

            var list = db.BlogPosts
                            .Where(x => x.IsPublished)
                            .OrderByDescending(x => x.DateCreated)
                            .ToList();

            return View(list);
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogPost post = db.BlogPosts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        [HttpPost]
        public ActionResult New(BlogPost post)
        {
            if (ModelState.IsValid)
            {
                post.DateCreated = DateTime.Now;
                post.DateModified = DateTime.Now;
                post.Author = "hajan";

                db.BlogPosts.Add(post);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}