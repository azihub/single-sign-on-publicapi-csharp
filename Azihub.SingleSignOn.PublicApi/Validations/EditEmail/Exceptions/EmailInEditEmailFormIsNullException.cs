using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.EditEmail.Exceptions
{
    public class EmailInEditEmailFormIsNullException : EditEmailFormException
    {
        public override int Code { get; } = (int)ErrorCodes.EmailInEditEmailFormIsNull;
        public override string LocaleConst => LocaleConsts.EMAIL_IS_NULL;
    }
}

