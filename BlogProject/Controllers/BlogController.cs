using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogProjectUI.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {

        BlogManager bm = new BlogManager(new EfBlog());
        CategoryManager cm = new CategoryManager(new EfCategory());
        public IActionResult Index()
        {
            var vList = bm.GetListWithCategory();
            return View(vList);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogByIDx(id);
            return View(values);
        }
        public IActionResult BlogListByWriter()
        {
            var values = bm.GetListWithCategoryByWriterBM(1);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddBlog()
        {
            
            List<SelectListItem> categoryvalues = (from x in cm.GetListAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.c = categoryvalues;

            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(blog);
            if (results.IsValid)
            {

                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.WriterID = 1;
                bm.Insert(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
        public IActionResult DeleteBlog(int id)
        {
            var vDelete = bm.GetBlogById(id);
            bm.Delete(vDelete);
            return RedirectToAction("BlogListWriter");
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            List<SelectListItem> categoryvalues = (from x in cm.GetListAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.c = categoryvalues;
            var vEdit = bm.GetBlogById(id);
            bm.Update(vEdit);
            return View();
        }
        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
           
            blog.WriterID = 1;
            blog.BlogCreateDate= DateTime.Parse(DateTime.Now.ToShortDateString());
            blog.BlogStatus = true;
            bm.Update(blog);
            return RedirectToAction("BlogListByWriter");
        }

    }
}
