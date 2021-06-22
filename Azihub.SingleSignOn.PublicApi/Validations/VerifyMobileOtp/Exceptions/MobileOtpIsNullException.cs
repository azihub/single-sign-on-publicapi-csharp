using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyMobileOtp.Exceptions
{
    public class MobileOtpIsNullException : MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.MobileOtpIsNull;
        public override string LocaleConst => LocaleConsts.MOBILE_OTP_IS_Null;

    }
}
