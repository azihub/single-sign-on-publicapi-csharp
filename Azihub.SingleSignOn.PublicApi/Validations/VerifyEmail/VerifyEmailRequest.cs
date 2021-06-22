using System;
using System.Runtime.Serialization;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyEmail
{
    [DataContract]
    public class VerifyEmailRequest
    {
        [Obsolete("Not allowed to use this for domain instantiation")]
        public VerifyEmailRequest()
        {

        }
        public VerifyEmailRequest(Guid ssoUserGuid, string otp, string userAgent, string userIPAddress)
        {
            SsoUserGuid = ssoUserGuid;
            Otp = otp;
            UserIPAddress = userIPAddress;
            UserAgent = userAgent;
        }

        [DataMember(Order = 1)]
        public Guid SsoUserGuid { get; set; }

        [DataMember(Order = 2)]
        public string Otp { get; set; }
        [DataMember(Order = 3)]
        public string UserIPAddress { get; set; }
        [DataMember(Order = 4)]
        public string UserAgent { get; set; }
    }
}
