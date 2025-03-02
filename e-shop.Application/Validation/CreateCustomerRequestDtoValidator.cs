using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using e_shop.Application.Dtos;
using FluentValidation;

namespace e_shop.Application.Validation
{
    public class CreateCustomerRequestDtoValidator : AbstractValidator<CreateCustomerRequestDto>
    {
        public CreateCustomerRequestDtoValidator()
        {
            var phoneNumber = new Regex(@"^\d{10}$");
            RuleFor(r => r.FirstName)
                .Length(1, 100)
                .WithMessage("Name should be less than 100 characters");
        }
    }
}
