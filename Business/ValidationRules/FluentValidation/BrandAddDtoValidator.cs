using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandAddDtoValidator : AbstractValidator<BrandAddDto> 
    {
        public BrandAddDtoValidator()
        {
            //rules
            RuleFor(p => p.Name).NotEmpty();
        }
    }
}
