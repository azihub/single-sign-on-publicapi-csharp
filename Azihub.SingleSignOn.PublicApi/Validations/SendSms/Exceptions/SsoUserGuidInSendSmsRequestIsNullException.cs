using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.SendSms.Exceptions
{
    public class SsoUserGuidInSendSmsRequestIsNullException : SendSmsException
    {
        public override int Code { get; } = (int)ErrorCodes.SsoUserGuidInSendSmsRequestIsNull;
        public override string LocaleConst => LocaleConsts.SSOUSERGUID_IS_NULL;
    }
}
