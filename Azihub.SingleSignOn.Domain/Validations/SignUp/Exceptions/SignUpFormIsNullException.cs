using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.SignUp.Exceptions
{
    public class SignUpFormIsNullException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.SignUpFormIsNull;
        public override string LocaleConst => LocaleConsts.SIGNUP_FORM_FAILED;
    }

}
