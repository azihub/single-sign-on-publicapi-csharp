using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;
using System;

namespace Azihub.SingleSignOn.Domain.Validations.SendSms.Exceptions
{
    public class SendSmsRequestSecurityException : SecurityException
    {
        public SendSmsRequestSecurityException()
        {

        }
        public SendSmsRequestSecurityException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
        public override int Code { get; } = (int)ErrorCodes.SendSmsRequestFailed;
        public override string LocaleConst => LocaleConsts.SEND_SMS_FAILED;
    }
}
