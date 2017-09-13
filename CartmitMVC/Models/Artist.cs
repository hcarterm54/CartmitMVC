using System.Collections.Generic;

namespace CartmitMVC.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }

        public static List<Artist> GetArtists()
        {
            return _artists;
        }

        private static List<Artist> _artists = new List<Artist>
        {
            new Artist
            {
                ArtistId = 1,
                Name = "Michael Jacob"
            },
            new Artist
            {
                ArtistId = 2,
                Name = "Rush"
            },
            new Artist
            {
                ArtistId = 3,
                Name = "Mark Knopfler"
            },
            new Artist
            {
                ArtistId = 4,
                Name = "Frank Sinatra"
            }
        };
    }
}