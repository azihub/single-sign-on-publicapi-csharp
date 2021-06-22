using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Utilities.Exceptions
{
    public class InstanceiIsNullException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.InstanceIsNull;
        public override string LocaleConst => LocaleConsts.INSTANCE_IS_NULL;
    }
}
