using MovieSample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MovieSample.Entities;

namespace MovieSample.Controllers
{
    public class RentController : Controller
    {
        private Context db = new Context();
        // GET: Rent
        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }

        // GET: Rent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rent/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rent/Edit/5
        public ActionResult Edit(int id)
        {
            var movieRent = new MovieRent();
            movieRent.MovieName = db.Movies.Where(t => t.ID == id).Select(m => m.Name).SingleOrDefault();
            movieRent.UserName = User.Identity.GetUserName();
            movieRent.RentDateTime = DateTime.Now;
            db.Rents.Add(movieRent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: Rent/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rent/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
