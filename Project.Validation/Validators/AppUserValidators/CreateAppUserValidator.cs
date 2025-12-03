using FluentValidation;
using Project.Validation.RequestModels.AppUserRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Validation.Validators.AppUserValidators
{
    public class CreateAppUserValidator:AbstractValidator<CreateAppUserRequestModel>
    {
        public CreateAppUserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("username cannot be null");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be null");

        }

    }
}
