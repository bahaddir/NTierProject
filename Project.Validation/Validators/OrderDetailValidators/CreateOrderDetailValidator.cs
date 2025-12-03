using FluentValidation;
using Project.Validation.RequestModels.AppUserProfileRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Validation.Validators.OrderDetailValidators
{
    public class CreateOrderDetailValidator:AbstractValidator<CreateOrderDetailRequestModel>
    {
        public CreateOrderDetailValidator()
        {
            RuleFor(x => x.OrderId).NotEmpty().WithMessage("OrderId cannot be null");
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("ProductId cannot be null");
            RuleFor(x => x.OrderId).GreaterThan(0).WithMessage("OrderId is invalid");
            RuleFor(x => x.ProductId).GreaterThan(0).WithMessage("ProductId is invalid");


        }

    }
}
