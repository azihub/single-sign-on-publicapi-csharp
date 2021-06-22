using System;
using System.Runtime.Serialization;

namespace Azihub.SingleSignOn.Domain.Validations.EditEmail
{
    [DataContract]
    public class EditEmailResponse
    {
        [Obsolete("Not allowed to use this for domain instantiation, must pass a Guid")]
        public EditEmailResponse()
        {

        }

        public EditEmailResponse(Guid ssoUserGuid)
        {
            SsoUserGuid = ssoUserGuid;
        }

        [DataMember(Order = 1)]
        public Guid SsoUserGuid { get; }
    }
}
