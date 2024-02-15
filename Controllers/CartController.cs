using Eshopper.Data;
using Eshopper.Infrastructure;
using Eshopper.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class CartController : Controller
    {
        private readonly AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }
        public Cart? Cart {set; get;}
        // GET: CartController
        public IActionResult Index()
        {
            return View("Cart", HttpContext.Session.GetJson<Cart>("cart"));
        }
        public ActionResult AddToCart(int productId)
        {
            Product? product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if(product != null)
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                Cart.AddItem(product, 1);
                HttpContext.Session.SetJson("cart", Cart);
            }
            return View("Cart", Cart);
        }
        public ActionResult UpdateCart(int productId)
        {
            Product? product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                Cart.AddItem(product, -1);
                HttpContext.Session.SetJson("cart", Cart);
            }
            return View("Cart", Cart);
        }
        public ActionResult RemoveFromCart(int productId)
        {
            Product? product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if(product != null)
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart");
                Cart.RemoveLine(product);
                HttpContext.Session.SetJson("cart", Cart);
            }
            return View("Cart", Cart);
        }

    }
}
