using BlogProjectUI.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectUI.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {
       
        private readonly UserManager<AppUser> _userManager;

        public RegisterUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignalUpViewModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Email = p.Mail,
                    UserName = p.UserName,
                    NameSurname = p.NameSurname
                };
                var result=await _userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
    }
}
