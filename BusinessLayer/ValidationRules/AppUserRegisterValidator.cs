using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("This place must not empty");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname must not empty");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail must not empty");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username must not empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password must not empty");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("ConfirmPassword must not empty");

            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Your Username must be minimum 5 character");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Your Username must be maximum 20 character");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Passwords is not same");
        }
    }
}
