using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Application.Dtos;
using FluentValidation;

namespace e_shop.Application.Validation
{
    public class CreateProductRequestDtoValidator : AbstractValidator<CreateProductRequesDto>
    {
        public CreateProductRequestDtoValidator()
        {
            RuleFor(r => r.ProductName)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(r => r.ProductDescription)
                .NotEmpty()
                .MaximumLength(500);

            RuleFor(r => r.Quantity)
                .GreaterThanOrEqualTo(0);

            RuleFor(r => r.SKU)
                .Length(16);

            // Published ga bo'glab quyamiz va uning qiymati true bo'lsa ProductNote va ProductWeight

            When(r => r.Published, () =>
            {
                RuleFor(r => r.ProductNote)
                    .NotEmpty()
                    .MaximumLength(100);

                RuleFor(r => r.ProductWeight)
                    .NotEmpty()
                    .GreaterThanOrEqualTo(0);
            });


        }
    }
}
