using Microsoft.AspNetCore.Mvc;
using SürdürülebilirTürkiye.DataAccessLayer;

namespace PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly Context _context;

        public ProductController(Context context)
        {
            _context = context;
        }

        public IActionResult Index(string category)
        {
            var products = _context.Products
                .Where(p => p.Category == category)
                .ToList();

            ViewBag.SelectedCategory = category;
            return View(products);
        }
    }
}
