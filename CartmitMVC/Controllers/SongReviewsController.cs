using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CartmitMVC.Models;

namespace CartmitMVC.Controllers
{
    public class SongReviewsController : Controller
    {
        // GET: SongReview
        public ActionResult Index()
        {
            var _reviews = SongReview.GetSongReviews();
            var model =
                from r in _reviews
                orderby r.Rating descending 
                select r;

            return View(model);
        }

        // GET: SongReview/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SongReview/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SongReview/Create
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

        // GET: SongReview/Edit/5
        public ActionResult Edit(int id)
        {
            var _reviews = SongReview.GetSongReviews();

            var review = _reviews.Single(r => r.Id == id);
            return View(review);
        }

        // POST: SongReview/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var _reviews = SongReview.GetSongReviews();

            var review = _reviews.Single(r => r.Id == id);
            if (TryUpdateModel(review))
            {
                return RedirectToAction("Index");
            }

            return View(review);
        }

        // GET: SongReview/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SongReview/Delete/5
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
