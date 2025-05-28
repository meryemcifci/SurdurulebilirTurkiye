using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SürdürülebilirTürkiye.DataAccessLayer;

namespace PresentationLayer.Controllers
{
   
    public class ContactController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly Context _context;

        public ContactController(UserManager<User> userManager, Context context)
        {
            this.userManager = userManager;
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Send(Contact contact)
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await userManager.FindByNameAsync(User.Identity.Name);
                if (user != null)
                {
                    contact.UserId = user.Id; // BaseEntity üzerinden gelen
                    contact.Name = user.UserName; 
                    contact.CreatedDate = DateTime.UtcNow;

                    _context.Contacts.Add(contact);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Success");
                }
            }

            return View(contact);
        }
    }
}
