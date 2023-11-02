using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _GuideList : ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EFGuideDal());

        public IViewComponentResult Invoke()
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
