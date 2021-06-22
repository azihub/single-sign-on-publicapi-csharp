using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.EmailForm.Exceptions
{
    public class EmailAddressIsNullException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.VerifyMobileOtpFailed;
        public override string LocaleConst => LocaleConsts.VERIFY_MOBILE_OTP_FAILED;
    }
}
