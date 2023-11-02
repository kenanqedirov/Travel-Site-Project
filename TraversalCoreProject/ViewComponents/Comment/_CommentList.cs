using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentDal());
        Context context = new Context();
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.CommentCount = context.Comments.Where(a=>a.DestinationID == id).Count();
            var values = commentManager.TGetListCommentWithDestinationAndUser(id);
            return View(values);
        }
    }
}
