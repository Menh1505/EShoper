using Eshopper.Data;
using Eshopper.Infrastructure;
using Eshopper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eshopper.Components
{
    public class CartWidget : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(HttpContext.Session.GetJson<Cart>("cart"));
        }
    }
}