using FluentValidation;
using Project.Validation.Validators.AppUserProfileValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Validation.Validators.AppUserValidators
{
    public class UpdateAppUserValidator : AbstractValidator<UpdateAppUserRequestModel>
    {
        public UpdateAppUserValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("invalid id");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("username cannot be null");
            RuleFor(x => x.Password).NotEmpty().WithMessage("pssword cannot be null");

        }

    }
}
