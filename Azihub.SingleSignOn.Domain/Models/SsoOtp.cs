using Azihub.SingleSignOn.Domain.Models.Abstracts;
using System;
using System.Net;

namespace Azihub.SingleSignOn.Domain.Models
{
    public class SsoOtp : EntityBase
    {
        public Guid SsoUserGuid { get; set; }
        public ulong Phone { get; set; }
        public string Otp { get; set; }
        public string MobileCountryIso2 { get; set; }
        public string NetworkCode { get; set; }
        public string MessageId { get; set; }
        public IPAddress UserIpAddress { get; set; }
        public string UserAgent { get; set; }
        public decimal? Cost { get; set; }
        public bool IsUsed { get; set; }
        public int FailedAttempt { get; set; }
        public bool Revoked { get; set; }
    }
}
