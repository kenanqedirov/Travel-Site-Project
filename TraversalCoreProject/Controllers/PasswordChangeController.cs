using AutoMapper.Internal;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Threading.Tasks;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Controllers
{
    public class PasswordChangeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public PasswordChangeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel forgetPasswordViewModel)
        {
            var user = await _userManager.FindByEmailAsync(forgetPasswordViewModel.Mail);
            string passwordResetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var passwordResetTokenLink = Url.Action("ResetPassword", "PasswordChange", new
            {
                userId = user.Id,
                token = passwordResetToken
            },HttpContext.Request.Scheme);

            //MimeMessage mimeMessage = new MimeMessage();

            //MailboxAddress mailboxAddresFrom = new MailboxAddress("Admin", "k.qedirov1999@gmail.com");
            //mimeMessage.From.Add(mailboxAddresFrom);

            //MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
            //mimeMessage.To.Add(mailboxAddressTo);
            //var bodyBuilder = new BodyBuilder();
            //bodyBuilder.TextBody = mailRequest.Body;
            //mimeMessage.Body = bodyBuilder.ToMessageBody();
            //mimeMessage.Subject = mailRequest.Subject;
            //SmtpClient client = new SmtpClient();
            //client.Connect("smtp.gmail.com", 587, false);
            //client.Authenticate("k.qedirov1999@gmail.com", "ttvq lpau dwiw fwie");
            //client.Send(mimeMessage);
            //client.Disconnect(true);



            return View();
        }
    }
}
