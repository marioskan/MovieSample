using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieSample.Data;
using MovieSample.Entities;

namespace MovieSample.Controllers
{
    public class MovieRentsController : Controller
    {
        private Context db = new Context();

        // GET: MovieRents
        public ActionResult Index()
        {
            return View(db.Rents.ToList());
        }

        // GET: MovieRents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieRent movieRent = db.Rents.Find(id);
            if (movieRent == null)
            {
                return HttpNotFound();
            }
            return View(movieRent);
        }

        // GET: MovieRents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieRents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,UserName,MovieName,RentDateTime")] MovieRent movieRent)
        {
            if (ModelState.IsValid)
            {
                db.Rents.Add(movieRent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movieRent);
        }

        // GET: MovieRents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieRent movieRent = db.Rents.Find(id);
            if (movieRent == null)
            {
                return HttpNotFound();
            }
            return View(movieRent);
        }

        // POST: MovieRents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,UserName,MovieName,RentDateTime")] MovieRent movieRent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movieRent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movieRent);
        }

        // GET: MovieRents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieRent movieRent = db.Rents.Find(id);
            if (movieRent == null)
            {
                return HttpNotFound();
            }
            return View(movieRent);
        }

        // POST: MovieRents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovieRent movieRent = db.Rents.Find(id);
            db.Rents.Remove(movieRent);
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
