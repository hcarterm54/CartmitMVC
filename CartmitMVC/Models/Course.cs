using System.Collections.Generic;

namespace CartmitMVC.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public static List<Course> GetCourseList()
        {
            return _courses;
        }

        private static List<Course> _courses = new List<Course>
        {
            new Course
            {
                CourseId = 1,
                Name = "HawksView Golf Club",
                City = "Lake Geneva",
                State = "WI",
                Country = "USA"
            },
            new Course
            {
                CourseId = 2,
                Name = "HeatherRidge Golf Course",
                City = "Gurnee",
                State = "IL",
                Country = "USA"
            },
            new Course
            {
                CourseId = 3,
                Name = "The Arboretum Club",
                City = "Buffalo Grove",
                State = "IL",
                Country = "USA"
            }
        };
    }
}