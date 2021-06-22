using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.EmailForm.Exceptions
{
    public class EmailBodyIsNullException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.EmailBodyIsNull;
        public override string LocaleConst => LocaleConsts.EMAIL_BODY_IS_NULL;
    }
}
