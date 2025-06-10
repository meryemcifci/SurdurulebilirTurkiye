using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SürdürülebilirTürkiye.DataAccessLayer;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")] //Yalnızca admin erişebilir.
    public class AdminDashboardController : Controller
    {
        private readonly Context _context;

        public AdminDashboardController(Context context)
        {
            _context = context;
        }
        // Admin paneli için ana sayfa
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
