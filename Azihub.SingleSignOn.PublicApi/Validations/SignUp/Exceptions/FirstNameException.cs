
using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.SignUp.Exceptions
{
    public class FirstNameIsNullException : SignUpFormException
    {
        public override int Code { get; } = (int)ErrorCodes.FirstNameIsNull;
        public override string LocaleConst => LocaleConsts.FIRST_NAME_IS_NULL;
    }
    public class FirstNameIsShortException : SignUpFormException
    {
        public override int Code { get; } = (int)ErrorCodes.FirstNameIsShort;
        public override string LocaleConst => LocaleConsts.FIRST_NAME_IS_SHORT;
    }
    public class FirstNameIsLongException : SignUpFormException
    {
        public override int Code { get; } = (int)ErrorCodes.FirstNameIsLong;
        public override string LocaleConst => LocaleConsts.FIRST_NAME_IS_LONG;
    }
}
