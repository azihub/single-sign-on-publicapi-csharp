using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.SendSms.Exceptions
{
    public class SendSmsRequestIsNullException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.SendSmsRequestIsNull;
        public override string LocaleConst => LocaleConsts.SEND_SMS_REQUEST_IS_NULL;
    }
}
