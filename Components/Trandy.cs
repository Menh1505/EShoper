using Eshopper.Data;
using Microsoft.AspNetCore.Mvc;

namespace Eshopper.Components
{
    public class Trandy : ViewComponent
    {
        private readonly AppDbContext _context;

        public Trandy(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View(_context.Products.Where(p => p.IsTrandy == true).ToList());
        }
    }
}