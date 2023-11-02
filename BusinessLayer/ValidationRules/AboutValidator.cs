using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AboutValidator : AbstractValidator<About>
	{
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("There will not empty");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Please added photo");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Using Minimum 50 character");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Using Maximum 1500 characters");
        
        }
    }
}
