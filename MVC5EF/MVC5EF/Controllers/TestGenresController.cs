using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5EF.Models.DBContent;

namespace MVC5EF.Controllers
{
    public class TestGenresController : Controller
    { 
        //db connection
    private MusicStoreDBContent dbContent = new MusicStoreDBContent();
    
        // GET: TestGenres/Create
        public ActionResult Index()
        {
            var result = dbContent.Genres.ToList();
            return View(result);
            return View();
        }
        // POST : 
        public ActionResult Create()
        {
            return View();
        }
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GenreId,Name,Description")] Genre genre)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(genre).State = EntityState.Modified;
                dbContent.Genres.Add(genre);
                dbContent.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(genre);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Genre genre = dbContent.Genres.Find(id);
            if (genre == null)
            {
                return HttpNotFound();
            }
            return View(genre);
        }
        // POST: Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Genre genre = dbContent.Genres.Find(id);
            dbContent.Genres.Remove(genre);
            dbContent.SaveChanges();
            return RedirectToAction("Index");
        }
        // GET: Genres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Genre genre = dbContent.Genres.Find(id);
            if (genre == null)
            {
                return HttpNotFound();
            }
            return View(genre);
        }

        // POST: Genres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GenreId,Name,Description")] Genre genre)
        {
            if (ModelState.IsValid)
            {
                dbContent.Entry(genre).State = EntityState.Modified;
                dbContent.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(genre);
        }
    }
}