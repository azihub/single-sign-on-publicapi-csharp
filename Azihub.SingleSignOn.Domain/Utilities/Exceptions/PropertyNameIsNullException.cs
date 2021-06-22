using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Utilities.Exceptions
{
    public class PropertyNameIsNullException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.PropertyNameIsNull;
        public override string LocaleConst => LocaleConsts.PROPERTY_NAME_IS_NULL;
    }
}
