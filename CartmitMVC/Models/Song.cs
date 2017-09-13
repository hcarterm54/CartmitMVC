using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CartmitMVC.Models
{
    /// <summary>
    /// http://www.musicgenreslist.com/
    /// </summary>  
    public enum Genre
    {
        Americana,
        Blues,
        Country,
        Rock,
        Metal,
        Pop,
        Swing,
        Classical
    }

    public class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Released { get; set; }
        public Genre Genre { get; set; }

        public static List<Song> GetSongList()
        {
            return _songs;
        }

        private static List<Song> _songs = new List<Song>
        {
            new Song
            {
                SongId = 1,
                Title = "Will You Love Me Again",
                Artist = "Michael Jacob",
                Genre = Genre.Americana,
                Released = "2016"
            },
            new Song
            {
                SongId = 2,
                Title = "Golden Heart",
                Artist = "Mark Knopfler",
                Genre = Genre.Rock,
                Released = "1996"
            },
            new Song
            {
                SongId = 3,
                Title = "Working Man",
                Artist = "Rush",
                Genre = Genre.Rock,
                Released = "1974"
            },
            new Song
            {
                SongId = 4,
                Title = "Night and Day",
                Artist = "Frank Sinatra ",
                Genre = Genre.Swing,
                Released = "1996"
            },
            new Song
            {
                SongId = 5,
                Title = "Smooth",
                Artist = "Santana",
                Genre = Genre.Rock,
                Released = "1999"
            },
        };
    }
}