/*Created By Engin Yenice
enginyenice2626@gmail.com*/

using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(color => color.ColorName).NotEmpty();
        }
    }
}