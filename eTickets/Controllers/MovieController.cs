using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;
        public MovieController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var movies = _context.Movie.Include(m => m.Cinema).OrderBy(m => m.Name).ToList();
            return View(movies);
        }
    }
}
