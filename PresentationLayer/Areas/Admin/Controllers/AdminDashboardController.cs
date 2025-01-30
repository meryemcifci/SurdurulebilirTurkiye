using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")] //Yalnızca admin erişebilir.
    public class AdminDashboardController : Controller
    {
        public IActionResult Index()
        {
            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Index", "Home"); // Admin olmayan kullanıcıyı user paneline yönlendir
            }
            return View();
        }
    }
}
