using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectUI.Controllers
{
	[Authorize]
	public class WriterController : Controller
	{
		
		public IActionResult Index()
		{
			return View();
		}
        public IActionResult Inddex()
        {
            return View();
        }
		[AllowAnonymous]
		public PartialViewResult WriterNavbarPartial() 
		{
			return PartialView();
		}
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

    }
}
