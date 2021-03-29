using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMovie.Data;
using WebApiMovie.Models;

namespace WebApiMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieContext _context;
        public MovieController(MovieContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _context.Movies.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> Get( int id)
        {
            var movie = _context.Movies.FirstOrDefault(x => x.Id == id);
            if( movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        [HttpGet("GetByDate/{date}")]
        public IEnumerable<Movie> GetByDate(int date)
        {
            //  IEnumerable<Movie> movies = (from c in _context.Movies where c.ReleaseYear == date select c).ToList();
            IEnumerable<Movie> movies = _context.Movies.Where(x => x.ReleaseYear == date).ToList();

            if (movies == null)
            {
                return (IEnumerable<Movie>)NotFound();
            }

            return movies;
        }



    }
}
