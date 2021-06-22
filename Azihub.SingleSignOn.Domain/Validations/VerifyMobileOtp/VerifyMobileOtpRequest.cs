using System;
using System.Runtime.Serialization;

namespace Azihub.SingleSignOn.Domain.Validations.VerifyMobileOtp
{
    [DataContract]
    public class VerifyMobileOtpRequest
    {
        [Obsolete("Not allowed to use this for domain instantiation")]
        public VerifyMobileOtpRequest()
        {

        }
        public VerifyMobileOtpRequest(Guid ssoUserGuid, string otp, string userAgent, string userIPAddress)
        {
            SsoUserGuid = ssoUserGuid;
            Otp = otp;
            UserIPAddress = userIPAddress;
            UserAgent = userAgent;
        }

        [DataMember(Order = 1)]
        public Guid SsoUserGuid { get; private set; }

        [DataMember(Order = 2)]
        public string Otp { get; private set; }
        [DataMember(Order = 3)]
        public string UserIPAddress { get; private set; }
        [DataMember(Order = 4)]
        public string UserAgent { get; private set; }
    }
}
