using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyMobileOtp.Exceptions
{
    public class MobileOtpException : BusinessLogicException
    {
        public MobileOtpException()
        {
        }

        /// <summary>
        /// Pass array of errors when form submit is initiated by MVC Project 
        /// </summary>
        /// <param name="errors"></param>
        public MobileOtpException(BusinessLogicException[] errors)
        {
            Errors = errors;
        }
        public override int Code { get; } = (int)ErrorCodes.VerifyMobileOtp;
        public override string LocaleConst => LocaleConsts.VERIFY_MOBILE_OTP_FAILED;

    }
}
