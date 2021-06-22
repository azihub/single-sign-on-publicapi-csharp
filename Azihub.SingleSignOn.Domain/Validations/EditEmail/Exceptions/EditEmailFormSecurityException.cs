using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;
using System;

namespace Azihub.SingleSignOn.Domain.Validations.EditEmail.Exceptions
{
    public class EditEmailFormSecurityException : SecurityException
    {
        public EditEmailFormSecurityException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
        public override int Code { get; } = (int)ErrorCodes.EditEmailFormIsFailed;
        public override string LocaleConst => LocaleConsts.EDIT_EMAIL_FAILED;
    }
}
