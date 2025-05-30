using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using System.Linq;
using System;
using SürdürülebilirTürkiye.DataAccessLayer;
using System.Security.Claims;

namespace PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly Context _context;

        public ContactController(Context context)
        {
            _context = context;
        }

        // GET: /Contact/Index
        public IActionResult Contact()
        {
            if (!User.Identity.IsAuthenticated)
            {
                TempData["LoginRequired"] = "true";
                return View();
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(Contact contact)
        {
            try
            {
                if (!User.Identity.IsAuthenticated)
                {
                    return Json(new { success = false, message = "Lütfen giriş yapın." });
                }

                // UserId'yi önce set et (ModelState validation'dan önce)
                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ??
                            User.FindFirst("sub")?.Value ??
                            User.Identity.Name ??
                            User.FindFirst(ClaimTypes.Name)?.Value ??
                            "anonymous";

                contact.UserId = userId;
                contact.SentDate = DateTime.Now;
                contact.CreatedDate = DateTime.Now;
                contact.ContactID = 0; // Auto-increment için

                // ModelState'den UserId hatasını kaldır
                ModelState.Remove("UserId");
                ModelState.Remove("ContactID");
                ModelState.Remove("SentDate");
                ModelState.Remove("CreatedDate");

                // Model validation
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                    return Json(new { success = false, message = "Form verileri geçersiz: " + string.Join(", ", errors) });
                }

                // Gerekli alanları kontrol et
                if (string.IsNullOrEmpty(contact.Name) ||
                    string.IsNullOrEmpty(contact.Email) ||
                    string.IsNullOrEmpty(contact.Subject) ||
                    string.IsNullOrEmpty(contact.Message))
                {
                    return Json(new { success = false, message = "Tüm alanları doldurun." });
                }

                // Veritabanına kaydetme işlemi
                _context.Contacts.Add(contact);
                await _context.SaveChangesAsync();

                return Json(new { success = true, message = "Mesajınız başarıyla iletildi!" });
            }
            catch (Exception ex)
            {
                // Hata logla (gerçek uygulamada proper logging kullan)
                Console.WriteLine($"Contact mesaj gönderme hatası: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                Console.WriteLine($"Inner exception: {ex.InnerException?.Message}");

                return Json(new { success = false, message = "Mesaj gönderilirken bir hata oluştu: " + ex.Message });
            }
        }
    }
}