using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;
using System;

namespace Azihub.SingleSignOn.Domain.Validations.SignUp.Exceptions
{
    public class SignUpFormSecurityException : SecurityException
    {
        public SignUpFormSecurityException()
        {

        }
        public SignUpFormSecurityException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
        public override int Code { get; } = (int)ErrorCodes.SignUpFormFailed;
        public override string LocaleConst => LocaleConsts.SIGNUP_FORM_FAILED;
    }

}
