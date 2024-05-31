using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.Portfolios
{
    public class PortfolioValid : AbstractValidator<Portfolio>
    {
        public PortfolioValid()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen isim giriniz...*");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen  giriniz...*");    
        }
    }
}
