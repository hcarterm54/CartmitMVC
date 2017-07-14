﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CartmitMVC.Models;

namespace CartmitMVC.Controllers
{
    public class CourseReviewsController : Controller
    {
        // GET: CourseReviews
        public ActionResult Index()
        {
            var model = from r in _reviews
                orderby r.Country
                select r;

            return View(model);
        }

        // GET: CourseReviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CourseReviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseReviews/Create
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

        // GET: CourseReviews/Edit/5
        public ActionResult Edit(int id)
        {

            var review = _reviews.Single(r => r.Id == id);
            return View(review);
        }

        // POST: CourseReviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _reviews.Single(r => r.Id == id);
            if (TryUpdateModel(review))
            {
                return RedirectToAction("Index");
            }

            return View(review);
        }

        // GET: CourseReviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CourseReviews/Delete/5
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

        [ChildActionOnly]
        public ActionResult BestReview()
        {
            var bestReview = from r in _reviews
                orderby r.Rating descending
                select r;

            return PartialView("_CourseReview", bestReview.First());
        }

        static List<CourseReview> _reviews = new List<CourseReview>
        {
            new CourseReview
            {
                Id = 1,
                Name = "HawksView Golf Club",
                City = "Lake Geneva",
                Country = "USA",
                Rating = 9
            },
            new CourseReview
            {
                Id = 2,
                Name = "HeatherRidge Golf Course",
                City = "Lake Geneva",
                Country = "USA",
                Rating = 6
            },
            new CourseReview
            {
                Id = 3,
                Name = "The Arboretum Club",
                City = "Wheeling",
                Country = "USA",
                Rating = 7
            },
        };
    }
}