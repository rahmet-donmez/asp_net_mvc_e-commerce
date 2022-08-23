using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(x => x.UserFirstName).NotEmpty().WithMessage("Ad bos gecilemez");
            RuleFor(x => x.UserLastName).NotEmpty().WithMessage("Soyad bos gecilemez");
            RuleFor(x => x.UserPassword).NotEmpty().WithMessage("Sifre bos gecilemez");
            RuleFor(x => x.UserEmail).NotEmpty().WithMessage("Email bos gecilemez");
            RuleFor(x => x.UserPassword).MaximumLength(20).WithMessage("Sifre en fazla 20 karakter içermelidic");
            RuleFor(x => x.UserPassword).MinimumLength(2).WithMessage("Sifre en az 2 karakter icermelidir");



        }
    }
}
