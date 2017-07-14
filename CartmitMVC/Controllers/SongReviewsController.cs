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
            var model = from r in _reviews
                orderby r.Artist
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
            var review = _reviews.Single(r => r.Id == id);
            return View(review);
        }

        // POST: SongReview/Edit/5
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

        static List<SongReview> _reviews = new List<SongReview>
        {
            new SongReview
            {
                Id = 1,
                Title = "Will You Love Me Again",
                Artist = "Michael Jacob",
                Review = "A striking ballad from the debut EP from St. Mojo, this song features...highlights the songwriting skills of singer and lead guitarist Michael Jacob, whose earlier endeavors included his first band, Overseer (Wide is the Path, 1993) and Proximity...",
                Released = "2016"
            },
            new SongReview
            {
                Id = 2,
                Title = "Golden Heart",
                Artist = "Mark Knopfler",
                Review = "The title track from the 1996 album, Golden Heart",
                Released = "1996"
            },
            new SongReview
            {
                Id = 3,
                Title = "Working Man",
                Artist = "Rush",
                Review = "From the self-titled debute album, this marvelous piece features original drummer John Rutsey...and also found it's way into their 1976 album 'All the World's a Stage with Neil Peart on drums",
                Released = "1974"
            },
        };

    }
}
