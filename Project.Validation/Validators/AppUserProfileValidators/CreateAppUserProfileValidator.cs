using FluentValidation;
using Project.Validation.RequestModels.AppUserProfileRequestModels;
using Project.Validation.RequestModels.AppUserRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Validation.Validators.AppUserProfileValidators
{
    public class CreateAppUserProfileValidator:AbstractValidator<CreateAppUserProfileRequestModel>
    {
        public CreateAppUserProfileValidator()
        {
            RuleFor(x => x.AppUserId).GreaterThan(0).WithMessage("appuserid is invalid");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("first name cannot be null");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("last name cannot be null");
        }

    }
}
