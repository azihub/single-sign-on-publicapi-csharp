using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyMobileOtp.Exceptions
{
    public class MobileOtpLenghtIsInvalidException : MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.MobileOtpLenghtIsInvalid;
        public override string LocaleConst => LocaleConsts.MOBILE_OTP_LENGHT_IS_INVALID;
    }
}
