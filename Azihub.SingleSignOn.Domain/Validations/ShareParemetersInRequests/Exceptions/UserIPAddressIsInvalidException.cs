using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.ShareParemetersInRequests.Exceptions
{
    public class UserIPAddressIsInvalidException : SecurityException
    {
        public override int Code { get; } = (int)ErrorCodes.UserIPAddressIsInvalid;
        public override string LocaleConst => LocaleConsts.USER_IP_ADDRESS_IS_INVALID;
    }
}
