using System;
using System.Linq;
using System.Web.Http;
using VidlyNew.Dtos;
using VidlyNew.Models;

namespace VidlyNew.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpPost]
        public IHttpActionResult CreateRentail(NewRentalsDto newRentalsDto)
        {
            var customer = _context.Customers.SingleOrDefault(
                c => c.Id == newRentalsDto.CustomerId);

            if (customer == null)
                return BadRequest("CustomerId is not valid");

            if (newRentalsDto.MovieIds.Count() == 0)
                return BadRequest("No Movie Ids have been given.");

            var movies = _context.Movies.Where(
                m => newRentalsDto.MovieIds.Contains(m.Id)).ToList();

            if(movies.Count != newRentalsDto.MovieIds.Count)
                return BadRequest("One or more movie id is invalid");


            foreach (var movie in movies)
            {
                if(movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie not available");
                }
                movie.NumberAvailable--;
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();

            return Ok();
        }
    }
}