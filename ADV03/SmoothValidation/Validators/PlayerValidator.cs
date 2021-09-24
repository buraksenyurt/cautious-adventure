using FluentValidation;
using SmoothValidation.Models;

namespace SmoothValidation.Validators
{
    public class PlayerValidator
        : AbstractValidator<Player>
    {
        public PlayerValidator()
        {
            RuleFor(p => p.Nickname).NotNull().NotEmpty().WithMessage("Lütfen oyunda kullanmak istediğin takma adı gir.");
            RuleFor(p => p.Nickname).MinimumLength(5).MaximumLength(10).WithMessage("Takma adın en az 5 en fazla 10 karakter olabilir.");
            RuleFor(p => p.Age).InclusiveBetween(18, 99).WithMessage("Yaş sınırımız 18 ile 99(zor ama) arası.");
            RuleFor(p => p.MobilePhone).Must(p => !string.IsNullOrEmpty(p) && p.StartsWith("+90")).WithMessage("Telefon numaran +90 ile başlamalı");
            RuleFor(p => p.Email).NotNull().NotEmpty().EmailAddress();
        }
    }
}
