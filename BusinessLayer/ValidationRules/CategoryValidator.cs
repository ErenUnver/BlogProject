using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("category adı kısmı boş geçilemez");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("category acıklama içerik boş olamaz");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("cattegory adı en fazla 50 karakter olabılır");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("category adını Lütfen en az 2 karakter girişi yapınız");
        }
    }
}
