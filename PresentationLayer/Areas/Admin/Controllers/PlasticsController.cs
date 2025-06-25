using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SürdürülebilirTürkiye.DataAccessLayer;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PlasticsController : Controller
    {
        private readonly Context _context;

        public PlasticsController(Context context)
        {
            _context = context;
        }
        // GET: PlasticsController
        public ActionResult Index()
        {
            var plastics = _context.Plastics.ToList();
            return View(plastics);
        }

        // GET: PlasticsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlasticsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlasticsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Plastic plastic, IFormCollection collection)
        {
            try {
                if (ModelState.IsValid)
                {
                    plastic.AddedDate = DateTime.Now;
                    _context.Plastics.Add(plastic);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(plastic);
            }
            catch(Exception ex)
            {
                return View(ex);
            }


        }

        // GET: PlasticsController/Edit/5
        public IActionResult Edit(int id)
        {
            var plastic = _context.Plastics.Find(id);
            if (plastic == null) return NotFound();
            return View(plastic);
        }

        // POST: PlasticsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Plastic plastic, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Plastics.Update(plastic);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(plastic);
            }
            catch (Exception ex)
            {
                return View(ex);
            }
        }

        // GET: PlasticsController/Delete/5
        public ActionResult Delete(int id)
        {
            var plastic = _context.Plastics.Find(id);
            if (plastic == null) return NotFound();

            _context.Plastics.Remove(plastic);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: PlasticsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
