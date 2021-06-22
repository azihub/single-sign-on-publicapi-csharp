using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.VerifyMobileOtp.Exceptions
{
    public class SsoUserGuidInVerifyMobileOtpRequestIsInvalidException : MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.SsoUserGuidInVerifyMobileOtpRequestIsInvalid;
        public override string LocaleConst => LocaleConsts.SSOUSERGUID_IS_INVALID;
    }
}
