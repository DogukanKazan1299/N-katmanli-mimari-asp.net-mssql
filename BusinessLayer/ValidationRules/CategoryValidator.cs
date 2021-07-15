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
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Geçilemez");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama Alanı Boş Olamaz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori Adı En Az 3 karakterli olmalı");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori adı max 50 karakter olabilir.");
        }
    }
}
