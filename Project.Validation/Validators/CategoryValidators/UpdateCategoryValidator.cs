using FluentValidation;
using Project.Validation.RequestModels.AppUserProfileRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Validation.Validators.CategoryValidators
{
    public class UpdateCategoryValidator : AbstractValidator<UpdateCategoryRequestModel>
    {
        public UpdateCategoryValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("invalid id");
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("CategoryName cannot be null");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description cannot be null");

        }

    }
}
