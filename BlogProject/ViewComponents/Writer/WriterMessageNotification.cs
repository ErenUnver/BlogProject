using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectUI.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        Message2Manager nm = new Message2Manager(new EfMessage2());
        public IViewComponentResult Invoke()
        {
            int id = 1;
            var values = nm.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
