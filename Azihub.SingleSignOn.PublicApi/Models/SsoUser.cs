using Azihub.SingleSignOn.PublicApi.Models.Abstracts;
using System.Net;

namespace Azihub.SingleSignOn.PublicApi.Models
{
    public class SsoUser : EntityBase
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public ulong? Mobile { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Country of Residence
        /// </summary>
        public string CountryResidenceIso2 { get; set; }
        public IPAddress UserIpAddress { get; set; }
        public string UserAgent { get; set; }
    }
}