using Entities.DTOs;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarAddDtoValidator : AbstractValidator<CarAddDto>    
    {
        public CarAddDtoValidator() 
        {
            // rules
        }
    }
}
