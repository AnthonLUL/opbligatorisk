using Microsoft.AspNetCore.Mvc;
using MovieAPI.Managers;
using MovieLibrary;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieApiController : ControllerBase
    {
        private readonly MovieApiManager _movieApiManager;
        public MovieApiController()
        {
            _movieApiManager = new MovieApiManager();
        }

        // GET: movies
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public IEnumerable<Movie> GetAll()
        {
            return _movieApiManager.GetAll();
        }

        // GET: movie by Id
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Movie> GetById(int id)
        {
            var movie = _movieApiManager.GetById(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }

        // POST: api/movies
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [HttpPost]
        public ActionResult<Movie> Post(Movie movie)
        {
            _movieApiManager.Post(movie);
            return CreatedAtAction(nameof(GetById), new { id = movie.Id }, movie);
        }

    }
}
