using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyMobileOtp.Exceptions
{
    public class SsoUserGuidInVerifyMobileOtpRequestIsInvalidException : MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.SsoUserGuidInVerifyMobileOtpRequestIsInvalid;
        public override string LocaleConst => LocaleConsts.SSOUSERGUID_IS_INVALID;
    }
}
