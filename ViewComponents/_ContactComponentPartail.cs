using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _ContactComponentPartail:ViewComponent
    {
        MyProtfolioContext context = new MyProtfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }
    }
}
