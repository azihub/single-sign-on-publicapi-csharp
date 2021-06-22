using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyMobileOtp.Exceptions
{
    public class MobileOtpIsInvalidException : MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.InvalidMobileOtp;
        public override string LocaleConst => LocaleConsts.MOBILE_OTP_IS_INVALID;

    }
}
