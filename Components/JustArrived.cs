using Eshopper.Data;
using Microsoft.AspNetCore.Mvc;

namespace Eshopper.Components
{
    public class JustArrived : ViewComponent
    {
        private readonly AppDbContext _context;

        public JustArrived(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View(_context.Products.Where(p => p.IsArrived == true).ToList());
        }
    }
}