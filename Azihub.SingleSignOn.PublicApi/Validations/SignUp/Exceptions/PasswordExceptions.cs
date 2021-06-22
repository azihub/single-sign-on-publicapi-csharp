
using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.SignUp.Exceptions
{
    public class PasswordExceptions : SignUpFormException
    {
        public override int Code { get; } = (int)ErrorCodes.PasswordIsNotStrong;
        public override string LocaleConst => LocaleConsts.PASSWORD_IS_NOT_STRONG;

    }
    public class PasswordIsNullException : SignUpFormException
    {
        public override int Code { get; } = (int)ErrorCodes.PasswordIsNull;
        public override string LocaleConst => LocaleConsts.PASSWORD_IS_NULL;

    }
}
