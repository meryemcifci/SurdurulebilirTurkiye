using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
