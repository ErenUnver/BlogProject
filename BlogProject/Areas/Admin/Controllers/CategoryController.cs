using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace BlogProjectUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]

    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategory());
        public IActionResult Index(int page=1)
        {
            var values=cm.GetListAll().ToPagedList(page, 3);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddCategory(Category p)
        {

            //fluentValidatıon için
            CategoryValidator cv = new CategoryValidator();
            ValidationResult results = cv.Validate(p);

            if (results.IsValid)  // eğer doğrulama gecerli ise
            {
                p.CategoryStatus = true; // yazar kayıt sırasında hatta almamak için burada ekleme yapıldı

                cm.Insert(p);

                return RedirectToAction("Index", "Category");

            }
            else
            {
                // varsa hataları ve sebeblerini gostermek için FOREACH kullan
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }

            }

            return View();


        }
        public IActionResult CategoryDelete(int id)
        {
            var valSilBlg = cm.GetById(id); //önce İd ye gore bulacak
            cm.Delete(valSilBlg);

            return RedirectToAction("Index");
        }
    }
}
