using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.EditEmail.Exceptions
{
    public class EmailInEditEmailFormIsNullException : EditEmailFormException
    {
        public override int Code { get; } = (int)ErrorCodes.EmailInEditEmailFormIsNull;
        public override string LocaleConst => LocaleConsts.EMAIL_IS_NULL;
    }
}

