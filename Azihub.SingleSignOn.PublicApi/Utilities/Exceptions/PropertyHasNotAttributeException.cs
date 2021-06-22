using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Utilities.Exceptions
{
    public class PropertyHasNotAttributeException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.PropertyHasNotAttribute;
        public override string LocaleConst => LocaleConsts.PROPERTY_HAS_NOT_ATTRIBUTE;
    }
}
