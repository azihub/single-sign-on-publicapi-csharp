using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.VerifyEmail.Exceptions
{
    public class VerifyEmailRequestIsNullException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.VerifyEmailRequestIsNull;
        public override string LocaleConst => LocaleConsts.VERIFY_EMAIL_REQUEST_IS_NULL;
    }
}
