using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.EmailForm.Exceptions
{
    public class EmailFormIsNullException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.EmailFormIsNull;
        public override string LocaleConst => LocaleConsts.EMAIL_FORM_IS_NULL;
    }
}
