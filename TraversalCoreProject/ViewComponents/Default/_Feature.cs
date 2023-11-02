using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EFFeatureDal());
        public IViewComponentResult Invoke()
        {
            //var values = featureManager.TGetList();
            //ViewBag.Image1=featureManager.
            return View();
        }
    }
}
