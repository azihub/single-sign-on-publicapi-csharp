using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.SendSms.Exceptions
{
    public class SendSmsException : BusinessLogicException
    {
        public SendSmsException()
        {
        }

        /// <summary>
        /// Pass array of errors when form submit is initiated by MVC Project 
        /// </summary>
        /// <param name="errors"></param>
        public SendSmsException(BusinessLogicException[] errors)
        {
            Errors = errors;
        }
        public override int Code { get; } = (int)ErrorCodes.SendSms;
        public override string LocaleConst => LocaleConsts.SEND_SMS_FAILED;
    }
}
