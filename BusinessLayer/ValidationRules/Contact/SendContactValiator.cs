using DToLayer.ContactDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.Contact
{
    public class SendContactValiator : AbstractValidator<SendMessageDto>
    {
        public SendContactValiator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen isim giriniz...*");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Lütfen mail giriniz...*");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Lütfen konu bilgisini giriniz...*");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Lütfen mesajınızı giriniz...*");
            RuleFor(x => x.MessageBody).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz...*");
            RuleFor(x => x.MessageBody).MaximumLength(500).WithMessage("Lütfen en fazla 500 karakter giriniz...*");
        }
    }
}
