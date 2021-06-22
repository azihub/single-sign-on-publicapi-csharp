using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain;
using Azihub.SingleSignOn.Domain.Locales;

namespace Arzshomar.Domain.Validations.Mobile.Exceptions
{
    public class InvalidEnum164NumberFormatException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.InvalidEnum164NumberFormat;
        public override string LocaleConst => LocaleConsts.INVALID_ENUM_164_NUMBER_FORMAT;
    }
}