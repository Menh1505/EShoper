using Eshopper.Data;
using Microsoft.AspNetCore.Mvc;

namespace Eshopper.Components
{
    public class Imagebar : ViewComponent
    {
        private readonly AppDbContext _context;

        public Imagebar(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View("Index", _context.Categories.ToList());
        }
    }
}