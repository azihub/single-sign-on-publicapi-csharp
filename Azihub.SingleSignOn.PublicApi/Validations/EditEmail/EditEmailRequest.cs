using System;
using System.Runtime.Serialization;

namespace Azihub.SingleSignOn.PublicApi.Validations.EditEmail
{
    [DataContract]
    public class EditEmailRequest
    {
        [Obsolete("Not allowed to use this for domain instantiation")]
        public EditEmailRequest()
        {
        }
        public EditEmailRequest(Guid ssoUserGuid, string email, string userAgent, string userIpAddress)
        {
            SsoUserGuid = ssoUserGuid;
            Email = email;
            UserAgent = userAgent;
            UserIPAddress = userIpAddress;
        }

        [DataMember(Order = 1)]
        public Guid SsoUserGuid { get; set; }
        [DataMember(Order = 2)]
        public string Email { get; private set; }
        [DataMember(Order = 3)]
        public string UserIPAddress { get; private set; }
        [DataMember(Order = 4)]
        public string UserAgent { get; private set; }
    }
}
