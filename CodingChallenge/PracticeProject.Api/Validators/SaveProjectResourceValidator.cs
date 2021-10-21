using FluentValidation;
using PracticeProject.Api.Resources;

namespace PracticeProject.Api.Validations
{
    public class SaveProjectResourceValidator : AbstractValidator<SaveProjectResource>
    {
        public SaveProjectResourceValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty()
                .MaximumLength(50);
            
            RuleFor(m => m.Id)
                .NotEmpty()
                .WithMessage("'User Id' must not be 0.");
        }
    }
}