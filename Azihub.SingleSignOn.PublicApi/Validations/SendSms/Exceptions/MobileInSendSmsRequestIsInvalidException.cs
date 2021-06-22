using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.SendSms.Exceptions
{
    public class MobileInSendSmsRequestIsInvalidException : SendSmsException
    {
        public override int Code { get; } = (int)ErrorCodes.MobileInSendSmsRequestIsInvalid;
        public override string LocaleConst => LocaleConsts.MOBILE_NUMBER_IS_INVALID;
    }
}
