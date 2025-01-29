using BussinesLayer.Services;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenericController<T> : ControllerBase where T : class
    {
        private readonly IGenericService<T> _service;
        private readonly UserManager<User> _userManager;

        public GenericController(IGenericService<T> service, UserManager<User> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        [HttpGet("user")]
        public async Task<IActionResult> GetUserItems()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return Unauthorized();
            var items = await _service.GetByUserIdAsync(user.Id);
            return Ok(items);
        }
    }

}
