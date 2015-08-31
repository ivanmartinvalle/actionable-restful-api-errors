using ActionableRestfulApiErrors.Models;
using FluentValidation;

namespace ActionableRestfulApiErrors.Validation
{
    public class UserInputModelValidator : AbstractValidator<UserInputModel>
    {
        public UserInputModelValidator()
        {
            RuleFor(x => x.Username)
                .Must(x => x.Length >= 4)
                .When(x => x.Username != null)
                .WithState(x => new ErrorState
                {
                    ErrorCode = ErrorCode.TooShort,
                    DeveloperMessageTemplate = "{0} must be at least 4 characters",
                    DocumentationPath = "/Usernames",
                    UserMessage = "Please enter a username with at least 4 characters"
                });

            RuleFor(x => x.Address.ZipCode)
                .Must(x => x != null)
                .When(x => x.Address != null)
                .WithState(x => new ErrorState
                {
                    ErrorCode = ErrorCode.Required,
                    DeveloperMessageTemplate = "{0} is required",
                    DocumentationPath = "/Addresses",
                    UserMessage = "Please enter a Zip Code"
                });
        }
    }
}