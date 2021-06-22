using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.ShareParemetersInRequests.Exceptions
{
    public class ShareParemetersRequestIsNullException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.ShareParemetersRequestIsNull;
        public override string LocaleConst => LocaleConsts.SHAREPAREMETERS_REQUEST_IS_NULL;
    }
}
