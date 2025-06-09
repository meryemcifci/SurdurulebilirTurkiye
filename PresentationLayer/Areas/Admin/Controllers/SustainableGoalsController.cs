using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SürdürülebilirTürkiye.DataAccessLayer;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SustainableGoalsController : Controller
    {
        private readonly Context _context;

       
        public SustainableGoalsController(Context context)
        {
            _context = context;
        }
        // GET: SustainableGoalsController
        public async Task<IActionResult> Index()
        {
            var goals = await _context.SustainabilityGoals.ToListAsync();
            return View(goals);
        }

        // GET: SustainableGoalsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SustainableGoalsController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: SustainableGoalsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SustainabilityGoal goal, IFormFile IconImage)
        {
                try
                {
                    if (ModelState.IsValid)
                    {
                        if (IconImage != null && IconImage.Length > 0)
                        {
                            // wwwroot/images/ klasörüne kaydet
                            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                            Directory.CreateDirectory(uploadsFolder); // klasör yoksa oluştur

                            var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(IconImage.FileName);
                            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                await IconImage.CopyToAsync(stream);
                            }

                            // Sadece dosya yolunu veritabanına yaz
                            goal.IconUrl = "/images/" + uniqueFileName;
                        }

                        _context.SustainabilityGoals.Add(goal);
                        await _context.SaveChangesAsync();

                        return RedirectToAction("Index");
                    }

                    // ModelState geçerli değilse, sayfayı hatalarla döndür
                    return View(goal);
                }
                catch (Exception ex)
                {
                    // Hata mesajını ViewBag ile View'a taşı
                    ViewBag.Error = "Hata oluştu: " + ex.Message;
                    return View(goal);
                }
         
        }

        // GET: SustainableGoalsController/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var goal = await _context.SustainabilityGoals.FindAsync(id);
            if (goal == null) return NotFound();
            return View(goal);
        }

        // POST: SustainableGoalsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SustainabilityGoal goal)
        {
            if (ModelState.IsValid)
            {
                _context.Update(goal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(goal);
        }

        // GET: SustainableGoalsController/Delete/5
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var goal = await _context.SustainabilityGoals.FindAsync(id);
            if (goal == null) return NotFound();
            return View(goal);
        }

        // POST: SustainableGoalsController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var goal = await _context.SustainabilityGoals.FindAsync(id);
            if (goal != null)
            {
                _context.SustainabilityGoals.Remove(goal);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
