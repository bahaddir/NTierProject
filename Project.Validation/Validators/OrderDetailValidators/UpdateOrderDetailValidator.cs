using FluentValidation;
using Project.Validation.RequestModels.AppUserProfileRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Validation.Validators.OrderDetailValidators
{
    public class UpdateOrderDetailValidator:AbstractValidator<UpdateOrderDetailRequestModel>
    {
        public UpdateOrderDetailValidator()
        {
            RuleFor(x => x.OrderId).NotEmpty().WithMessage("OrderId cannot be null");
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("ProductId cannot be null");
            RuleFor(x => x.OrderId).GreaterThan(0).WithMessage("OrderId is invalid");
            RuleFor(x => x.ProductId).GreaterThan(0).WithMessage("ProductId is invalid");
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id is invalid");
        }
    }
}
