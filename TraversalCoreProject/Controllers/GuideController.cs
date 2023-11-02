using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class GuideController : Controller
    {
        GuideManager _guideManager = new GuideManager(new EFGuideDal());
        public IActionResult Index()
        {
            var values = _guideManager.TGetList();
            return View(values);
        }
    }
}
