using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CartmitMVC.Models
{
    public class SongReview
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Review { get; set; }
        public string Released { get; set; }
    }
}