using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Please add username")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Please add password")]
        public string Password { get; set; }
    }
}
