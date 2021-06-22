using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyEmail.Exceptions
{
    public class EmailOtpIsInvalidException : EmailTokenException
    {
        public override int Code { get; } = (int)ErrorCodes.InvalidEmailOtp;
        public override string LocaleConst => LocaleConsts.EMAIL_OTP_IS_INVALID;
    }

}