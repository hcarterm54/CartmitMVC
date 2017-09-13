using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CartmitMVC.Models
{
    public class SongReviewViewModel
    {
        public int Id { get; set; }
        public Genre Genre { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
    }

    public class SongReview
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }

        public static List<SongReviewViewModel> GetSongReviews()
        {
            var songs = Song.GetSongList();
            var reviews = GetReviews();

            var results =
                from c in reviews
                join d in songs on c.SongId equals d.SongId
                select new { d.Genre, d.Title, d.Artist, c.Rating, c.Review };

            List<SongReviewViewModel> songReviews = new List<SongReviewViewModel>();

            int i = 1;
            SongReviewViewModel rev = new SongReviewViewModel();
            foreach (var review in results)
            {
                songReviews.Add(new SongReviewViewModel { Id = i, Title = review.Title, Artist = review.Artist, Rating = review.Rating, Genre = review.Genre, Review = review.Review });
                i++;
            }

            return songReviews;
        }

        private static List<SongReview> GetReviews()
        {
            return _reviews;
        }

        private static List<SongReview> _reviews = new List<SongReview>
        {
            new SongReview
            {
                Id = 1,
                SongId = 1,
                Rating = 4,
                Review = "A striking ballad from the debut EP from St. Mojo, this song features...highlights the songwriting skills of singer and lead guitarist Michael Jacob, whose earlier endeavors included his first band, Overseer (Wide is the Path, 1993) and Proximity...",
            },
            new SongReview
            {
                Id = 2,
                SongId = 2,
                Rating = 4,
                Review = "The title track from the 1996 album, Golden Heart",
            },
            new SongReview
            {
                Id = 3,
                SongId = 3,
                Rating = 5,
                Review = "From the self-titled debute album, this marvelous piece features original drummer John Rutsey...and also found it's way into their 1976 album 'All the World's a Stage with Neil Peart on drums",
            },
            new SongReview
            {
                Id = 4,
                SongId = 4,
                Rating = 3,
                Review = "Silky smooth voice that defined the Rat Pack."
            },
            new SongReview
            {
                Id = 5,
                SongId = 5,
                Rating = 5,
                Review = "Best version a smokin' hot music video with Rob Thomas and smokin' hot babes!"
            }
        };
    }
}