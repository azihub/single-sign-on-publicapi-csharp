using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyEmail.Exceptions
{
    public class EmailOtpIsNullException : EmailTokenException
    {
        public override int Code { get; } = (int)ErrorCodes.EmailOtpIsNull;
        public override string LocaleConst => LocaleConsts.EMAIL_OTP_IS_NULL;
    }

}
