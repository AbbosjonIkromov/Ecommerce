using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Application.Dtos;
using FluentValidation;

namespace e_shop.Application.Validation
{
    public class CreateOrderRequestDtoValidator : AbstractValidator<CreateOrderRequestDto>
    {
        public CreateOrderRequestDtoValidator()
        {
            RuleFor(r => r.CustomerId)
                .NotEmpty()
                .WithMessage("CustomerId is required");
        }
    }
}
