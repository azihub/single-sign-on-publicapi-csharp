using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.EditEmail.Exceptions
{
    public class SsoUserGuidInEmailFormIsNullExeption : EditEmailFormException
    {
        public override int Code { get; } = (int)ErrorCodes.SsoUserGuidInEmailFormIsNull;
        public override string LocaleConst => LocaleConsts.SSOUSERGUID_IS_NULL;
    }
}
