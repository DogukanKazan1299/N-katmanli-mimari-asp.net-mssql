using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("YAZAR ADI BOŞ GEÇİLEMEZ");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar adı en az 2 harfli olmalıdır");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("YAZAR SOYADI BOŞ GEÇİLEMEZ");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("YAZAR soyadı max 50 olur");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("YAZAR hakkında BOŞ GEÇİLEMEZ");
        }
    }
}
