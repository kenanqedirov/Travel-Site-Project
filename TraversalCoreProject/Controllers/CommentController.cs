using EntityLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EFCommentDal());
      

        [HttpGet]
        public PartialViewResult AddComment()
        {
            //var value = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.destID = id;
            //ViewBag.userID = value.Id;
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment p)
        {

            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentState = true;
            commentManager.TAdd(p);
            return RedirectToAction("Index","Destination");
        }
    }
}
