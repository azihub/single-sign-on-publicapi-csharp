using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.SendSms.Exceptions
{
    public class MobileInSendSmsRequestIsNullException : SendSmsException
    {
        public override int Code { get; } = (int)ErrorCodes.MobileInSendSmsRequestIsNull;
        public override string LocaleConst => LocaleConsts.MOBILE_NUMBER_IS_NULL;

    }
}
