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
    public class Daybook_orderController : Controller
    {
        private MvcDaybookContainer db = new MvcDaybookContainer();

        // GET: Daybook_order
        public ActionResult Index()
        {
            var daybook_order = db.Daybook_order.Include(d => d.Product).Include(d => d.Daybook_line);
            return View(daybook_order.ToList());
        }

        // GET: Daybook_order/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Daybook_order daybook_order = db.Daybook_order.Find(id);
            if (daybook_order == null)
            {
                return HttpNotFound();
            }
            return View(daybook_order);
        }

        // GET: Daybook_order/Create
        public ActionResult Create()
        {
            ViewBag.ProductId = new SelectList(db.Product, "Id", "name");
            ViewBag.Daybook_lineId = new SelectList(db.Daybook_line, "Id", "Id");
            return View();
        }

        // POST: Daybook_order/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,s_price,quantity,name,ProductId,Daybook_lineId")] Daybook_order daybook_order)
        {
            if (ModelState.IsValid)
            {
                db.Daybook_order.Add(daybook_order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductId = new SelectList(db.Product, "Id", "name", daybook_order.ProductId);
            ViewBag.Daybook_lineId = new SelectList(db.Daybook_line, "Id", "Id", daybook_order.Daybook_lineId);
            return View(daybook_order);
        }

        // GET: Daybook_order/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Daybook_order daybook_order = db.Daybook_order.Find(id);
            if (daybook_order == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductId = new SelectList(db.Product, "Id", "name", daybook_order.ProductId);
            ViewBag.Daybook_lineId = new SelectList(db.Daybook_line, "Id", "Id", daybook_order.Daybook_lineId);
            return View(daybook_order);
        }

        // POST: Daybook_order/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,s_price,quantity,name,ProductId,Daybook_lineId")] Daybook_order daybook_order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(daybook_order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductId = new SelectList(db.Product, "Id", "name", daybook_order.ProductId);
            ViewBag.Daybook_lineId = new SelectList(db.Daybook_line, "Id", "Id", daybook_order.Daybook_lineId);
            return View(daybook_order);
        }

        // GET: Daybook_order/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Daybook_order daybook_order = db.Daybook_order.Find(id);
            if (daybook_order == null)
            {
                return HttpNotFound();
            }
            return View(daybook_order);
        }

        // POST: Daybook_order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Daybook_order daybook_order = db.Daybook_order.Find(id);
            db.Daybook_order.Remove(daybook_order);
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
