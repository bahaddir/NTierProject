using FluentValidation;
using Project.Validation.RequestModels.AppUserProfileRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Validation.Validators.OrderValidators
{
    public class CreateOrderValidator:AbstractValidator<CreateOrderRequestModel>
    {
        public CreateOrderValidator()
        {
            RuleFor(x => x.ShippingAddress).NotEmpty().WithMessage("ShippingAddress cannot be null");
            RuleFor(x => x.AppUserId).NotEmpty().WithMessage("AppUserId cannot be null");
            RuleFor(x => x.AppUserId).GreaterThan(0).WithMessage("AppUserId is invalid");
        }
    }
}
