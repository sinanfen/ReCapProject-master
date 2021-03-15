/*Created By Engin Yenice
enginyenice2626@gmail.com*/

using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(brand => brand.BrandName).NotEmpty();
        }
    }
}