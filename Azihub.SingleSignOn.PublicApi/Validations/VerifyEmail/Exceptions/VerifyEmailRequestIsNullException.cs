using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyEmail.Exceptions
{
    public class VerifyEmailRequestIsNullException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.VerifyEmailRequestIsNull;
        public override string LocaleConst => LocaleConsts.VERIFY_EMAIL_REQUEST_IS_NULL;
    }
}
