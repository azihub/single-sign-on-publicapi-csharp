using System;
using System.Runtime.Serialization;

namespace Azihub.SingleSignOn.PublicApi.Validations.SignUp
{
    [DataContract]
    public class SignUpFormResponse
    {
        [Obsolete("Not allowed to use this for domain instantiation, must pass a Guid")]
        public SignUpFormResponse()
        {

        }

        public SignUpFormResponse(Guid ssoUserGuid)
        {
            SsoUserGuid = ssoUserGuid;
        }

        [DataMember(Order = 1)]
        public Guid SsoUserGuid { get; }
    }
}