using System;
using System.Runtime.Serialization;

namespace Azihub.SingleSignOn.Domain.Validations.VerifyMobileOtp
{
    [DataContract]
    public class VerifyMobileOtpResponse
    {
        [Obsolete("Not allowed to use this for domain instantiation, must pass a Guid")]
        public VerifyMobileOtpResponse()
        {

        }

        public VerifyMobileOtpResponse(Guid ssoUserGuid)
        {
            SsoUserGuid = ssoUserGuid;
        }

        [DataMember(Order = 1)]
        public Guid SsoUserGuid { get; }
    }
}
