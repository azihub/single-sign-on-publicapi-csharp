using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.VerifyEmail.Exceptions
{
    public class SsoUserGuidInVerifyEmailRequestIsNullException : EmailTokenException
    {
        public override int Code { get; } = (int)ErrorCodes.SsoUserGuidInVerifyEmailRequestIsNull;
        public override string LocaleConst => LocaleConsts.SSOUSERGUID_IS_NULL;
    }

}
