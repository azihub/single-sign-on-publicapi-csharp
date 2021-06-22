using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyMobileOtp.Exceptions
{
    public class VerifyMobileOtpRequestIsNullException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.VerifyMobileOtpFailed;
        public override string LocaleConst => LocaleConsts.VERIFY_MOBILE_OTP_REQUEST_IS_NULL;
    }
}
