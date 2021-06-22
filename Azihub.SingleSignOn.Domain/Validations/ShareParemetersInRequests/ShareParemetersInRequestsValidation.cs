using Azihub.SingleSignOn.Domain.Validations.ShareParemetersInRequests.Exceptions;
using System.Net;

namespace Azihub.SingleSignOn.Domain.Validations.ShareParemetersInRequests
{
    public static class ShareParemetersInRequestsValidation
    {
        /// <summary>
        /// This is the method for checking the UserAgent and UserIPAddress.
        /// A UserAgentIsNullException is thrown If UserAgent is null,
        /// A UserIPAddressIsNullException is thrown If UserIPAdress is null,
        /// </summary>
        /// <param name="shareParemetersRequest"></param>
        /// <param name="signUpFormErrors"></param>
        /// <returns></returns>
        public static void Validate(ref ShareParemetersRequest shareParemetersRequest)
        {
            // Check shareParemetersRequest
            if (shareParemetersRequest == null)
                throw new ShareParemetersRequestIsNullException();

            // Check UserAgent
            if (string.IsNullOrEmpty(shareParemetersRequest.UserAgent))
                throw new UserAgentIsNullException();

            // Check UserIPAddress
            if (string.IsNullOrEmpty(shareParemetersRequest.UserIPAddress))
                throw new UserIPAddressIsNullException();

            else if (!ValidateIPAddress(shareParemetersRequest.UserIPAddress))
                throw new UserIPAddressIsInvalidException();

        }

        /// <summary>
        /// Validate UserIPAddress
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <returns></returns>
        private static bool ValidateIPAddress(string ipAddress)
        {
            IPAddress ip;
            return IPAddress.TryParse(ipAddress, out ip);
        }
    }
}
