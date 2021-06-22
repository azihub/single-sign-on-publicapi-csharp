using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.VerifyMobileOtp.Exceptions
{
    public class MobileOtpLenghtIsInvalidException : MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.MobileOtpLenghtIsInvalid;
        public override string LocaleConst => LocaleConsts.MOBILE_OTP_LENGHT_IS_INVALID;
    }
}
