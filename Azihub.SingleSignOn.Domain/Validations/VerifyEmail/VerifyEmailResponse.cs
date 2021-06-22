using System;
using System.Runtime.Serialization;

namespace Azihub.SingleSignOn.Domain.Validations.VerifyEmail
{
    [DataContract]
    public class VerifyEmailResponse
    {
        [Obsolete("Not allowed to use this for domain instantiation, must pass a Guid")]
        public VerifyEmailResponse()
        {

        }

        public VerifyEmailResponse(Guid ssoUserGuid)
        {
            SsoUserGuid = ssoUserGuid;
        }

        [DataMember(Order = 1)]
        public Guid SsoUserGuid { get; }
    }
}
