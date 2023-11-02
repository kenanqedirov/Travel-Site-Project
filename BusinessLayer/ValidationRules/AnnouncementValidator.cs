using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDto>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Please write a Title");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Please write a Description");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("PLease add minimum 5 character");
            RuleFor(x => x.Content).MinimumLength(5).WithMessage("PLease add minimum 5 character");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("PLease add maximum 50 character");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("PLease add maximum 500 character");
        }
    }
}
