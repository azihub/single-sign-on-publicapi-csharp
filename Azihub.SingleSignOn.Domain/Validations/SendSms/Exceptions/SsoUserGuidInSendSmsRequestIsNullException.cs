using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.SendSms.Exceptions
{
    public class SsoUserGuidInSendSmsRequestIsNullException : SendSmsException
    {
        public override int Code { get; } = (int)ErrorCodes.SsoUserGuidInSendSmsRequestIsNull;
        public override string LocaleConst => LocaleConsts.SSOUSERGUID_IS_NULL;
    }
}
