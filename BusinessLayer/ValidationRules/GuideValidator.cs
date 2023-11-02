using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please add name");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Please add Description");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Please add Image");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Please add maximum 30 character name");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Please add minimum 3 character name");

        }
    }
}
