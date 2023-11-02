using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage = "Please add name")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Please add surname")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Please add username")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Please add mail")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Please add password")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Please add ConfirmPassword")]
		[Compare("Password", ErrorMessage = "Confirm password is not true")]
		public string ConfirmPassword { get; set; }

	}
}
