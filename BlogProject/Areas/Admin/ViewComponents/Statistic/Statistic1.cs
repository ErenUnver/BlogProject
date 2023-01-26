﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace BlogProjectUI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlog());
        Context c= new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1=bm.GetListAll().Count();
            ViewBag.v2=c.Contact.Count();
            ViewBag.v3=c.Comments.Count();
            string api = "7cc153d134e2a6ebdbf706b53f65de19";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.weather = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View();
        }
    }
}
