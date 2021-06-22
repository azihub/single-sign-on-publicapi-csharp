using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyMobileOtp.Exceptions
{
    public class SsoUserGuidInVerifyMobileOtpRequestIsNullException : MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.SsoUserGuidInVerifyMobileOtpRequestIsNull;
        public override string LocaleConst => LocaleConsts.SSOUSERGUID_IS_NULL;
    }
}
