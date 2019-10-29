using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;
using VidlyNew.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrel!" };
            var customers = new List<Customer>
            {
                new Customer{Name = "Customer 1"},
                new Customer{Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Customers = customers,
                Movie = movie
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("ID = " + id);
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();
            var viewModel = new RandomMovieViewModel()
            {
                Movies = movies
            };
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie != null)
            {
                return View(movie);
            }
            return HttpNotFound();
        }

        [Route("movies/release/{year:regex(\\d{4})}/{month:maxlength(2)}")]
        //Constraints min max minlenght maxlength int float guid
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content("Year = " + year + " Month = " + month);
        }

      
    }
}