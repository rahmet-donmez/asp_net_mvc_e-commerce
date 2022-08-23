using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Urun adi bos gecilemez!");
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("Urun adi 100 karakteri gecemez!");
            RuleFor(x => x.ProductExplanation).NotEmpty().WithMessage("Urun aciklamasi bos gecilemez");
            RuleFor(x => x.ProductExplanation).MaximumLength(500).WithMessage("Urun aciklamasi 500 karakteri gecemez");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Urun kategorisi bos gecilemez");
            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("Urun fiyati bos gecilemez");

        }
    }
}
