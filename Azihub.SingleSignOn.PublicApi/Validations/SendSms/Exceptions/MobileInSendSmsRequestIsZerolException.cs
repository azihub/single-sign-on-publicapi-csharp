using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.SendSms.Exceptions
{
    public class MobileInSendSmsRequestIsZerolException : SendSmsException
    {
        public override int Code { get; } = (int)ErrorCodes.MobileInSendSmsRequestIsZero;
        public override string LocaleConst => LocaleConsts.MOBILE_NUMBER_IS_ZERO;
    }
}
