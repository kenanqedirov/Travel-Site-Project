using DTOLayer.DTOs.ContactDto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("This field must not empty");
            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("You must use minimum 5 character");
            RuleFor(x => x.Mail).MaximumLength(100).WithMessage("You must use maximum 100 character");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("You must use minimum 5 character");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("You must use maximum 100 character");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("This field must not empty");
            RuleFor(x => x.Name).NotEmpty().WithMessage("This field must not empty");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("This field must not empty");
        }
    }
}
