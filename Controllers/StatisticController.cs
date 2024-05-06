using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.Controllers
{
    public class StatisticController : Controller
    {
        MyProtfolioContext context = new MyProtfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x=>x.MessageIsRead==false).Count();
            ViewBag.v4 = context.Messages.Where(x=>x.MessageIsRead==true).Count();
            return View();
        }
    }
}
