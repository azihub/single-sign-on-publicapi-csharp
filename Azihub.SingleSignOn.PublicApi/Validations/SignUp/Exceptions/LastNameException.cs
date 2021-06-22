
using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.SignUp.Exceptions
{
    public class LastNameIsNullException : SignUpFormException
    {
        public override int Code { get; } = (int)ErrorCodes.LastNameIsNull;
        public override string LocaleConst => LocaleConsts.LAST_NAME_IS_NULL;
    }
    public class LastNameIsShortException : SignUpFormException
    {
        public override int Code { get; } = (int)ErrorCodes.LastNameIsShort;
        public override string LocaleConst => LocaleConsts.LAST_NAME_IS_SHORT;
    }
    public class LastNameIsLongException : SignUpFormException
    {
        public override int Code { get; } = (int)ErrorCodes.LastNameIsLong;
        public override string LocaleConst => LocaleConsts.LAST_NAME_IS_SHORT;
    }
}
