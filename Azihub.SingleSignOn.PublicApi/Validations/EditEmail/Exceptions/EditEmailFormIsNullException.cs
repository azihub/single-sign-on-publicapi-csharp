using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.EditEmail.Exceptions
{
    public class EditEmailFormIsNullException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.EditEmailFormIsNull;
        public override string LocaleConst => LocaleConsts.EDIT_EMAIL_FORM_IS_NULL;
    }
}
