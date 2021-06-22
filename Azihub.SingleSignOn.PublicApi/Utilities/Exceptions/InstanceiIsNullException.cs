using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Utilities.Exceptions
{
    public class InstanceiIsNullException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.InstanceIsNull;
        public override string LocaleConst => LocaleConsts.INSTANCE_IS_NULL;
    }
}
