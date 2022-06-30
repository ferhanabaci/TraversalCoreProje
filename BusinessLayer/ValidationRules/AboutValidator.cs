using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Kısmını Boş Geçemezsin..!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Resim Seçiniz..!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Lütfen minimum 50 karakterlik açıklama bilgisi giriniz.");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("lütfen Açıklamayı kısaltın..");


        }
    }
}
