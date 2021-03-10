using Entities.DTOs;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorAddDtoValidator : AbstractValidator<ColorAddDto>
    {
        public ColorAddDtoValidator()   
        {
            // rules
        }
    }
}
