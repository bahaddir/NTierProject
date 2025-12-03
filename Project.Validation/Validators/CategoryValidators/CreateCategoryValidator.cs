using FluentValidation;
using Project.Validation.RequestModels.AppUserProfileRequestModels;

namespace Project.Validation.Validators.CategoryValidators
{
    public class CreateCategoryValidator:AbstractValidator<CreateCategoryRequestModel>
    {
        public CreateCategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("category name cannot be null");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description cannot be null");

        }

    }
}
