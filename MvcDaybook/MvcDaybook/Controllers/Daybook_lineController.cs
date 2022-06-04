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
    public class Daybook_lineController : Controller
    {
        private MvcDaybookContainer db = new MvcDaybookContainer();

        // GET: Daybook_line
        public ActionResult Index()
        {
            var daybook_line = db.Daybook_line.Include(d => d.Daybook);
            return View(daybook_line.ToList());
        }

        // GET: Daybook_line/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Daybook_line daybook_line = db.Daybook_line.Find(id);
            if (daybook_line == null)
            {
                return HttpNotFound();
            }
            return View(daybook_line);
        }

        // GET: Daybook_line/Create
        public ActionResult Create()
        {
            ViewBag.DaybookId = new SelectList(db.Daybook, "Id", "name");
            return View();
        }

        // POST: Daybook_line/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,total,date,DaybookId")] Daybook_line daybook_line)
        {
            if (ModelState.IsValid)
            {
                db.Daybook_line.Add(daybook_line);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DaybookId = new SelectList(db.Daybook, "Id", "name", daybook_line.DaybookId);
            return View(daybook_line);
        }

        // GET: Daybook_line/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Daybook_line daybook_line = db.Daybook_line.Find(id);
            if (daybook_line == null)
            {
                return HttpNotFound();
            }
            ViewBag.DaybookId = new SelectList(db.Daybook, "Id", "name", daybook_line.DaybookId);
            return View(daybook_line);
        }

        // POST: Daybook_line/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,total,date,DaybookId")] Daybook_line daybook_line)
        {
            if (ModelState.IsValid)
            {
                db.Entry(daybook_line).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DaybookId = new SelectList(db.Daybook, "Id", "name", daybook_line.DaybookId);
            return View(daybook_line);
        }

        // GET: Daybook_line/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Daybook_line daybook_line = db.Daybook_line.Find(id);
            if (daybook_line == null)
            {
                return HttpNotFound();
            }
            return View(daybook_line);
        }

        // POST: Daybook_line/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Daybook_line daybook_line = db.Daybook_line.Find(id);
            db.Daybook_line.Remove(daybook_line);
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
