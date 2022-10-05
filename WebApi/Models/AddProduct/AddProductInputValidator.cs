using FluentValidation;

namespace WebApi.Models.AddProduct
{
    public class AddProductInputValidator : AbstractValidator<AddProductInput>
    {
        public AddProductInputValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Code).NotEmpty();
        }
    }
}