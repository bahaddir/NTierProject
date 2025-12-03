using FluentValidation;
using Project.Validation.RequestModels.AppUserProfileRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Validation.Validators.AppUserProfileValidators
{
    public class UpdateAppUserProfileRequestModelValidator : AbstractValidator<UpdateAppUserProfileRequestModel>
    {
        public UpdateAppUserProfileRequestModelValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("id is invalid");
            RuleFor(x => x.AppUserId).GreaterThan(0).WithMessage("appuserid is invalid");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("first name cannot be null");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("last name cannot be null");
        }
    }

}
