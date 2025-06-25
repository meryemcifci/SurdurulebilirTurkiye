//using BussinesLayer.Services;
//using EntityLayer.Concrete;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using SürdürülebilirTürkiye.DataAccessLayer;

//namespace PresentationLayer.Areas.Admin.Controllers
//{
//    [Area("Admin")]
//    public class NewsController : Controller
//    {
//        private readonly Context _context;
        

//        public NewsController(Context context)
//        {
//            _context = context;
           
//        }
     
//        [HttpGet]
//        public async Task<IActionResult> Index()
//        {
//            var news = await _newsService.GetAllNewsForAdminAsync();
//            return View(news);
//        }

//        // GET: Admin/News/Details/5
//        public async Task<IActionResult> Details(int id)
//        {
//            var news = await _newsService.GetNewsDetailAsync(id);
//            if (news == null)
//            {
//                return NotFound();
//            }
//            return View(news);
//        }

//        // GET: Admin/News/Create
//        public IActionResult Create()
//        {
//            var model = new NewsArticle
//            {
//                PublishedDate = DateTime.Now,
//                IsActive = true
//            };
//            return View(model);
//        }

//        // POST: Admin/News/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create(NewsArticle model)
//        {
//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    await _newsService.CreateNewsAsync(model);
//                    TempData["Success"] = "Haber başarıyla oluşturuldu.";
//                    return RedirectToAction(nameof(Index));
//                }
//                catch (Exception ex)
//                {
//                    ModelState.AddModelError("", "Haber oluşturulurken bir hata oluştu: " + ex.Message);
//                }
//            }
//            return View(model);
//        }

//        // GET: Admin/News/Edit/5
//        public async Task<IActionResult> Edit(int id)
//        {
//            var news = await _newsService.GetNewsForEditAsync(id);
//            if (news == null)
//            {
//                return NotFound();
//            }
//            return View(news);
//        }

//        // POST: Admin/News/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id, NewsArticle model)
//        {
//            if (id != model.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    await _newsService.UpdateNewsAsync(model);
//                    TempData["Success"] = "Haber başarıyla güncellendi.";
//                    return RedirectToAction(nameof(Index));
//                }
//                catch (Exception ex)
//                {
//                    ModelState.AddModelError("", "Haber güncellenirken bir hata oluştu: " + ex.Message);
//                }
//            }
//            return View(model);
//        }

//        // GET: Admin/News/Delete/5
//        public async Task<IActionResult> Delete(int id)
//        {
//            var news = await _newsService.GetNewsDetailAsync(id);
//            if (news == null)
//            {
//                return NotFound();
//            }
//            return View(news);
//        }

//        // POST: Admin/News/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(int id)
//        {
//            try
//            {
//                await _newsService.DeleteNewsAsync(id);
//                TempData["Success"] = "Haber başarıyla silindi.";
//            }
//            catch (Exception ex)
//            {
//                TempData["Error"] = "Haber silinirken bir hata oluştu: " + ex.Message;
//            }
//            return RedirectToAction(nameof(Index));
//        }
//    }
//}
