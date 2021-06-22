
using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.SignUp.Exceptions
{
    public class EmailIsAlreadyRegisterException : SignUpFormException
    {
        public override int Code { get; } = (int)ErrorCodes.EmailIsAlreadyRegister;
        public override string LocaleConst => LocaleConsts.EMAIL_IS_ALREADY_REGISTER;
    }
    public class EmailIsNullException : SignUpFormException
    {
        public override int Code { get; } = (int)ErrorCodes.EmailIsNull;
        public override string LocaleConst => LocaleConsts.EMAIL_IS_NULL;
    }
    public class EmailIsInvalidException : SignUpFormException
    {
        public override int Code { get; } = (int)ErrorCodes.EmailIsInvalid;
        public override string LocaleConst => LocaleConsts.EMAIL_IS_INVALID;
    }
}
