using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectUI.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
            NotificationManager nm = new NotificationManager(new EfNotification());

            public IViewComponentResult Invoke()
            {
                var values = nm.GetListAll();
                return View(values);
            }
           
       
    }
}
