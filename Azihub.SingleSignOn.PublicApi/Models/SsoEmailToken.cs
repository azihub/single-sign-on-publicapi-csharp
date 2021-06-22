using Azihub.SingleSignOn.PublicApi.Models.Abstracts;
using System;
using System.Net;

namespace Azihub.SingleSignOn.PublicApi.Models
{
    public class SsoEmailToken : EntityBase
    {
        public Guid SsoUserGuid { get; set; }
        public string Email { get; set; }
        public bool Verified { get; set; }
        public IPAddress UserIpAddress { get; set; }
        public string UserAgent { get; set; }
        public Guid VerifyToken { get; set; }
        public string Otp { get; set; }
        public bool Revoked { get; set; }
    }
}