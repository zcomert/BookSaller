using BookSaller.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSaller.Entities.ValidationRules.FluentValidation
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(b => b.Title)
                .NotEmpty()
                .NotNull()
                .Length(2, 50)
                .WithMessage("Kitap adı boş olamaz.");

            RuleFor(b => b.UnitPrice)
                .NotEmpty()
                .NotNull()
                .GreaterThan(10)
                .WithMessage("Kitap adı boş olmaz ve 10 TL düşük olamaz.");
        }
    }
}
