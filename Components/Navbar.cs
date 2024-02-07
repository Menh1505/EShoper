using Eshopper.Data;
using Microsoft.AspNetCore.Mvc;

namespace Eshopper.Components
{
    public class Navbar : ViewComponent
    {
        private readonly AppDbContext _context;

        public Navbar(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View(_context.Categories.ToList());  
        }
    }
}