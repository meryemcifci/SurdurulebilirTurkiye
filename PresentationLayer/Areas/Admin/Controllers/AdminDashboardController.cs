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

        //#region SKA-Sürdürülebilir Kalkınma Amaçları

        //// Admin paneli için SKA (Sürdürülebilir Kalkınma Amaçları) sayfası
        //// SKA - Listeleme
        //public async Task<IActionResult> SKA()
        //{
        //    var goals = await _context.SustainabilityGoals.ToListAsync();
        //    return View(goals);
        //}
        //// GET: Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(SustainabilityGoal goal)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(goal);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(SKA));
        //    }
        //    return View(goal);
        //}

        //// GET: Edit
        //public async Task<IActionResult> Edit(int id)
        //{
        //    var goal = await _context.SustainabilityGoals.FindAsync(id);
        //    if (goal == null) return NotFound();
        //    return View(goal);
        //}

        //// POST: Edit
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(SustainabilityGoal goal)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Update(goal);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(SKA));
        //    }
        //    return View(goal);
        //}

        //// GET: Delete (Onay sayfası gibi)
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var goal = await _context.SustainabilityGoals.FindAsync(id);
        //    if (goal == null) return NotFound();
        //    return View(goal);
        //}

        //// POST: Delete (Silme işlemi)
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var goal = await _context.SustainabilityGoals.FindAsync(id);
        //    if (goal != null)
        //    {
        //        _context.SustainabilityGoals.Remove(goal);
        //        await _context.SaveChangesAsync();
        //    }
        //    return RedirectToAction(nameof(SKA));
        //}

        //#endregion

        // Admin paneli için kullanıcı yönetimi sayfası
        public IActionResult Users()
        {
            return View();
        }
      
    }
}
