using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.EditEmail.Exceptions
{
    public class SsoUserGuidInEmailFormIsNullExeption : EditEmailFormException
    {
        public override int Code { get; } = (int)ErrorCodes.SsoUserGuidInEmailFormIsNull;
        public override string LocaleConst => LocaleConsts.SSOUSERGUID_IS_NULL;
    }
}
