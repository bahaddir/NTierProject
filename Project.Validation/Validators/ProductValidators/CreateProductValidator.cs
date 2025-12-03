using FluentValidation;
using Project.Validation.RequestModels.AppUserProfileRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Validation.Validators.ProductValidators
{
    public class CreateProductValidator:AbstractValidator<CreateProductRequestModel>
    {
        public CreateProductValidator()
        {
            RuleFor(x=>x.ProductName)
                .NotEmpty().WithMessage("Product name is required.")
                .MaximumLength(100).WithMessage("Product name cannot exceed 100 characters.");
            RuleFor(x=>x.UnitPrice)
                .GreaterThan(0).WithMessage("Price must be greater than zero.");
                        RuleFor(x=>x.CategoryId)
                .NotEmpty().WithMessage("Category ID is required.");
        }
    }
}
