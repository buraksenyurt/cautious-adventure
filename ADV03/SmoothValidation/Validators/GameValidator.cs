using FluentValidation;
using SmoothValidation.Models;
using System;

namespace SmoothValidation.Validators
{
    public class GameValidator
        : AbstractValidator<Game>
    {
        public GameValidator()
        {
            RuleFor(a => a.Name).NotNull().NotEmpty();
            RuleFor(a => a.Info)
                .NotNull()
                .NotEmpty()
                .MaximumLength(500)
                .WithMessage("Lütfen söyleyeceklerin 500 karakterde fazla olmasın");
            RuleFor(a => a.Year)
                .InclusiveBetween(1970, DateTime.Now.Year)
                .WithMessage("Oyun 1970 ile 2021 arasında yapılmış olmalı");
        }
    }
}
