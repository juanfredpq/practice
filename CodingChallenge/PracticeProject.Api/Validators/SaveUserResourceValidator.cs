using FluentValidation;
using PracticeProject.Api.Resources;

namespace PracticeProject.Api.Validations
{
    public class SaveUserResourceValidator : AbstractValidator<SaveUserResource>
    {
        public SaveUserResourceValidator()
        {
            RuleFor(a => a.FirstName)
                .NotEmpty()
                .MaximumLength(50);
        }
    }
}