using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        MyProtfolioContext protfolioContext = new MyProtfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = protfolioContext.Skills.ToList();
            return View(values);
        }
    }
}
