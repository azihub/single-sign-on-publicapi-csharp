using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Utilities.Exceptions
{
    public class PropertyHasNotAttributeException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.PropertyHasNotAttribute;
        public override string LocaleConst => LocaleConsts.PROPERTY_HAS_NOT_ATTRIBUTE;
    }
}
