using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using RamirezforaneoApp.Models;

namespace RamirezforaneoApp.Controllers.Admin
{
    [Authorize(Roles ="Admin")]
    public class UserManagmentController : Controller
    {
        private readonly UserManager<User> _userManager;

        public UserManagmentController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult>Index()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }
        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByIdAsync(id);
            return View(user);

        }

    }
}
