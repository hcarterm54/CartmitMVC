using System.Collections.Generic;
using System.Linq;

namespace CartmitMVC.Models
{
    public class CourseReviewViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
    }


    public class CourseReview
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public int CourseId { get; set; }

        public static List<CourseReviewViewModel> GetCourseReviews()
        {
            var courses = Course.GetCourseList();
            var reviews = GetReviews();

            var results =
                from c in reviews
                join d in courses on c.CourseId equals d.CourseId
                select new {d.Name, d.City, d.State, d.Country, c.Rating, c.Review};

            List<CourseReviewViewModel> courseReviews = new List<CourseReviewViewModel>();

            int i = 1;
            CourseReviewViewModel rev = new CourseReviewViewModel();
            foreach (var review in results)
            {
                courseReviews.Add(new CourseReviewViewModel{ Id = i, Name = review.Name, City = review.City, State = review.State, Country = review.Country, Rating = review.Rating, Review = review.Review });
                i++;
            }
            return courseReviews;
        }

        private static List<CourseReview> GetReviews()
        {
            return _reviews;
        }

        private static List<CourseReview> _reviews = new List<CourseReview>
        {
            new CourseReview
            {
                Id = 1,
                CourseId = 1,
                Rating = 9
            },
            new CourseReview
            {
                Id = 2,
                CourseId = 2,
                Rating = 6
            },
            new CourseReview
            {
                Id = 3,
                CourseId = 3,
                Rating = 7
            },
        };
    }
}