using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.Locales;
using System;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyEmail.Exceptions
{
    public class VerifyEmailRequestSecurityException : SecurityException
    {
        public VerifyEmailRequestSecurityException()
        {

        }
        public VerifyEmailRequestSecurityException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
        public override int Code { get; } = (int)ErrorCodes.VerifyEmailFailed;
        public override string LocaleConst => LocaleConsts.VERIFY_EMAIL_FAILED;
    }
}
