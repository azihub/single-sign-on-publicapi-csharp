using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.SignUp.Exceptions
{
    public class MobileIsAlreadyRegisterException : SignUpFormException
    {
        public override int Code { get; } = (int)ErrorCodes.MobileNumberIsAlreadyRegister;
        public override string LocaleConst => LocaleConsts.MOBILE_NUMBER_IS_ALREADY_REGISTER;
    }
    public class MobileIsNullException : SignUpFormException
    {
        public override int Code { get; } = (int)ErrorCodes.MobileIsNull;
        public override string LocaleConst => LocaleConsts.MOBILE_NUMBER_IS_NULL;
    }
    public class MobileIsInvalidException : SignUpFormException
    {
        public override int Code { get; } = (int)ErrorCodes.MobileIsInvalid;
        public override string LocaleConst => LocaleConsts.MOBILE_NUMBER_IS_INVALID;
    }
}
