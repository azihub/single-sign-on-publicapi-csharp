using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.SendSms.Exceptions
{
    public class SsoUserGuidInSmsRequestIsInvalidException : SendSmsException
    {
        public override int Code { get; } = (int)ErrorCodes.SsoUserGuidInSmsRequestIsInvalid;
        public override string LocaleConst => LocaleConsts.SSOUSERGUID_IS_INVALID;
    }

}
