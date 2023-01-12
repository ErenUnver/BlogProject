using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz.");
            RuleFor(x => x.BlogThumbnailImage).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz.");

            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Bu Alan En Az 5 Karakter Uzunluğunda Olmalıdır.");
        }
    }
}
