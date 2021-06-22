using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyEmail.Exceptions
{
    public class SsoUserGuidInVerifyEmailRequestIsInvalidException : EmailTokenException
    {
        public override int Code { get; } = (int)ErrorCodes.SsoUserGuidInVerifyEmailRequestIsNull;
        public override string LocaleConst => LocaleConsts.SSOUSERGUID_IS_INVALID;
    }

}
