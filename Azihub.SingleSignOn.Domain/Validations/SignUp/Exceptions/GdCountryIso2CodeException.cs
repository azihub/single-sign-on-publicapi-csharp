using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.SignUp.Exceptions
{
    public class GdCountryIso2CodeIsNullException : SignUpFormException
    {
        public override int Code { get; } = (int)ErrorCodes.GdCountryIso2CodeIsNull;
        public override string LocaleConst => LocaleConsts.GDCOUNTRYISO2CODE_IS_NULL;
    }
}
