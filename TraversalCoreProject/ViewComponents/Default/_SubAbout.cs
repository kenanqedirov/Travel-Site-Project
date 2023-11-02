using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        SubAboutManager SubAboutManager = new SubAboutManager(new EFSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = SubAboutManager.TGetList();
            return View(values);
        }
    }
}
