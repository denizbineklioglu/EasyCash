using EasyCash.DTO.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash.Business.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez");

            RuleFor(x => x.Name).MaximumLength(30).WithMessage("En fazla 30 karakter girişi yapabilirsiniz");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("En az 2 karakter girişi yapmalısınız.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolalar eşleşmedi.");
        }
    }
}
