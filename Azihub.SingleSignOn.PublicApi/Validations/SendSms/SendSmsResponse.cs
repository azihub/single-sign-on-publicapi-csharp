using System;
using System.Runtime.Serialization;

namespace Azihub.SingleSignOn.PublicApi.Validations.SendSms
{
    [DataContract]
    public class SendSmsResponse
    {
        [Obsolete("Not allowed to use this for domain instantiation, must pass a Guid")]
        public SendSmsResponse()
        {

        }

        public SendSmsResponse(Guid ssoUserGuid)
        {
            SsoUserGuid = ssoUserGuid;
        }

        [DataMember(Order = 1)]
        public Guid SsoUserGuid { get; }
    }
}
