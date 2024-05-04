using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyProtfolioContext protfolioContext = new MyProtfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = protfolioContext.Abouts.Select(x=>x.AboutTitle).FirstOrDefault();
            ViewBag.aboutSubDescriptiom = protfolioContext.Abouts.Select(x=>x.AboutSubDescrption).FirstOrDefault();
            ViewBag.aboutDetail = protfolioContext.Abouts.Select(x=>x.AboutDetails).FirstOrDefault();
            return View();
        }
    }
}
