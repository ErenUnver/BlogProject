using Microsoft.AspNetCore.Mvc;

namespace BlogProjectUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AdminNavbarPartiel()
        {
            return PartialView();
        }
    }
}
