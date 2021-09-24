using FluentValidation;
using SmoothValidation.Models;

namespace SmoothValidation.Validators
{
    public class PlayerValidator
        : AbstractValidator<Player>
    {
        public PlayerValidator()
        {
            RuleFor(p => p.Nickname)
                .NotNull()
                .NotEmpty()
                .MinimumLength(5)
                .WithMessage("Takma adın 5 karakterden az olamaz")
                .MaximumLength(10)
                .WithMessage("Takma adın en fazla 10 karakter olabilir.");

            RuleFor(p => p.Age).InclusiveBetween(18, 99).WithMessage("Yaş sınırımız 18 ile 99(zor ama) arası.");
            RuleFor(p => p.MobilePhone)
                .Must(p => !string.IsNullOrEmpty(p) && p.StartsWith("+90"))
                .WithMessage("Telefon numaran +90 ile başlamalı");
            RuleFor(p => p.Email).NotNull().NotEmpty().EmailAddress();

            RuleFor(p => p.FavoriteGame).InjectValidator(); // Game koleksiyonundaki Game nesne örnekleri için GameValidator'u enjekte ediyoruz.
        }
    }
}
