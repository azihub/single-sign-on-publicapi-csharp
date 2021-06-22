using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.VerifyMobileOtp.Exceptions
{
    public class MobileOtpIsNullException : MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.MobileOtpIsNull;
        public override string LocaleConst => LocaleConsts.MOBILE_OTP_IS_Null;

    }
}
