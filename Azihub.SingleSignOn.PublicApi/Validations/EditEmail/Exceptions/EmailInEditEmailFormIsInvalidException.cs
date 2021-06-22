using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.EditEmail.Exceptions
{
    public class EmailInEditEmailFormIsInvalidException : EditEmailFormException
    {
        public override int Code { get; } = (int)ErrorCodes.EmailInEditEmailFormIsInvalid;
        public override string LocaleConst => LocaleConsts.EMAIL_IS_INVALID;
    }
}
