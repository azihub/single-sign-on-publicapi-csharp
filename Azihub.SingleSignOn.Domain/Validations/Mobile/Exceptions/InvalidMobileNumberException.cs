using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain;
using Azihub.SingleSignOn.Domain.Locales;

namespace Arzshomar.Domain.Validations.Mobile.Exceptions
{
    public class InvalidMobileNumberException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.VerifyMobileOtpRequestIsNull;
        public override string LocaleConst => LocaleConsts.MOBILE_NUMBER_IS_INVALID;
    }
}