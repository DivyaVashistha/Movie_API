using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieAPI.Models;

namespace MovieAPI.Controllers.api
{
    public class MovieController : ApiController
    {
        ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

public IEnumerable<Movie> GetMovies()
        {
            return _context.Movie.ToList();
        }
    }
}
