using System;
using System.Runtime.Serialization;

namespace Azihub.SingleSignOn.PublicApi.Validations.SendSms
{
    [DataContract]
    public class SendSmsRequest
    {
        [Obsolete("Not allowed to use this for domain instantiation")]
        public SendSmsRequest()
        {

        }
        public SendSmsRequest(Guid ssoUserGuid, string mobile, string userAgent, string userIPAddress)
        {
            SsoUserGuid = ssoUserGuid;
            Mobile = mobile;
            UserIPAddress = userIPAddress;
            UserAgent = userAgent;
        }

        [DataMember(Order = 1)]
        public Guid SsoUserGuid { get; set; }

        [DataMember(Order = 2)]
        public string Mobile { get; private set; }

        [DataMember(Order = 3)]
        public string UserIPAddress { get; private set; }
        [DataMember(Order = 4)]
        public string UserAgent { get; private set; }
    }
}
