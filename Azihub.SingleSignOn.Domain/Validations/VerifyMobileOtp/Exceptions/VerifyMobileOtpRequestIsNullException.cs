using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.VerifyMobileOtp.Exceptions
{
    public class VerifyMobileOtpRequestIsNullException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.VerifyMobileOtpFailed;
        public override string LocaleConst => LocaleConsts.VERIFY_MOBILE_OTP_REQUEST_IS_NULL;
    }
}
