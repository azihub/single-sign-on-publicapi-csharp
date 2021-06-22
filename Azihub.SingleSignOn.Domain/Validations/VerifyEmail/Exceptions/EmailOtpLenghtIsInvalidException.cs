using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.VerifyEmail.Exceptions
{
    public class EmailOtpLenghtIsInvalidException : EmailTokenException
    {
        public override int Code { get; } = (int)ErrorCodes.EmailOtpLenghtIsInvalid;
        public override string LocaleConst => LocaleConsts.EMAIL_OTP_LENGHT_IS_INVALID;
    }
}
