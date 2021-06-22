using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.VerifyMobileOtp.Exceptions
{
    public class SsoUserGuidInVerifyMobileOtpRequestIsNullException : MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.SsoUserGuidInVerifyMobileOtpRequestIsNull;
        public override string LocaleConst => LocaleConsts.SSOUSERGUID_IS_NULL;
    }
}
