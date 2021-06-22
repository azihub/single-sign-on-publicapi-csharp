using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.SignUp.Exceptions
{
    public class SignUpFormIsNullException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.SignUpFormIsNull;
        public override string LocaleConst => LocaleConsts.SIGNUP_FORM_FAILED;
    }

}
