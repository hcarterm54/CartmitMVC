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
            var _reviews = CourseReview.GetCourseReviews();

            var model = from r in _reviews
                orderby r.Rating
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
            var _reviews = CourseReview.GetCourseReviews();

            var review = _reviews.Single(r => r.Id == id);
            return View(review);
        }

        // POST: CourseReviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var _reviews = CourseReview.GetCourseReviews();

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
            var _reviews = CourseReview.GetCourseReviews();

            var bestReview = from r in _reviews
                orderby r.Rating descending
                select r;

            return PartialView("_CourseReview", bestReview.First());
        }
    }
}
