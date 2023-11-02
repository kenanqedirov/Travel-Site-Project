using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());
        ReservationManager reservationManager = new ReservationManager(new EFReservationDal());

        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GetListWithReservationByAccepted(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GetListWithReservationByPrevious(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GetListWithReservationByWaitApproval(values.Id);
            return View(valuesList);
        }
        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            p.AppUserID = 1;
            p.Status = "Waiting";
            reservationManager.TAdd(p);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}
