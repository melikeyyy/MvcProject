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
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Bırakamazsınız ");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soyadını Boş Bırakamazsınız");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında Kısmını Boş Bırakamazsınız");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("En Az 2 Karakter Gİrişi Yapmalısınız");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("En Fazla 50 Karakter Girebilirsiniz");
        }
    }
}
