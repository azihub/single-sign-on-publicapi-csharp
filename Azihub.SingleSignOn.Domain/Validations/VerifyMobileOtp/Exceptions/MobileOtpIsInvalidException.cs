using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.VerifyMobileOtp.Exceptions
{
    public class MobileOtpIsInvalidException : MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.InvalidMobileOtp;
        public override string LocaleConst => LocaleConsts.MOBILE_OTP_IS_INVALID;

    }
}
