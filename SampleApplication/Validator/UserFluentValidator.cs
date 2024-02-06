using FluentValidation;
using user.Models;

namespace uservalidators
{
    public class UserFluentValidator : AbstractValidator<User>
    {
        public UserFluentValidator()
        {
            RuleFor(value=>value.Name).NotEmpty().MinimumLength(2).MaximumLength(20).Matches("^[a-zA-Z ]*$");
            RuleFor(value=>value.Email).EmailAddress();
        }
    }
}