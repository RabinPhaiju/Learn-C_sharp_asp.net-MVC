using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcDaybook.Models;

namespace MvcDaybook.Controllers
{
    public class DaybookController : Controller
    {
        private MvcDaybookContainer db = new MvcDaybookContainer();

        // GET: Daybook
        public ActionResult Index()
        {
            return View(db.Daybook.ToList());
        }

        // GET: Daybook/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Daybook daybook = db.Daybook.Find(id);
            if (daybook == null)
            {
                return HttpNotFound();
            }
            return View(daybook);
        }

        // GET: Daybook/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Daybook/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,name,user,month,date")] Daybook daybook)
        {
            if (ModelState.IsValid)
            {
                db.Daybook.Add(daybook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(daybook);
        }

        // GET: Daybook/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Daybook daybook = db.Daybook.Find(id);
            if (daybook == null)
            {
                return HttpNotFound();
            }
            return View(daybook);
        }

        // POST: Daybook/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,name,user,month,date")] Daybook daybook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(daybook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(daybook);
        }

        // GET: Daybook/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Daybook daybook = db.Daybook.Find(id);
            if (daybook == null)
            {
                return HttpNotFound();
            }
            return View(daybook);
        }

        // POST: Daybook/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Daybook daybook = db.Daybook.Find(id);
            db.Daybook.Remove(daybook);
            db.SaveChanges();
            return RedirectToAction("Index");
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
