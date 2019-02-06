using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateReleased { get; set; }
        public int Rating { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
    }
}