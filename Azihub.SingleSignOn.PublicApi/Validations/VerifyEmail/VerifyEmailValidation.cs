using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.Validations.ShareParemetersInRequests;
using Azihub.SingleSignOn.PublicApi.Validations.VerifyEmail.Exceptions;
using System;
using System.Collections.Generic;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyEmail
{
    public static class VerifyEmailValidation
    {
        /// <summary>
        /// This method wants to check the SsoUserGuid and otp.
        /// If any of these items are null or empty, email will not be verified.
        /// An VerifyEmailRequestIsNullException must be thrown if the emailFormRequest is null.
        /// An SsoUserGuidInVerifyEmailRequestIsNullException must be thrown if the SsoUserGuid is null or empty.
        /// An EmailOtpIsNullException must be thrown if the otp is null.
        /// An EmailOtpLenghtIsInvalidException must be thrown if the otp lenght is invalid.
        /// An InvalidEmailOtpException must be thrown if the otp is invalid.
        /// </summary>
        /// <param name="verifyEmailRequest"></param>
        /// <param name="businessLogicExceptions"></param>
        /// <returns></returns>
        public static List<BusinessLogicException> Validate(ref VerifyEmailRequest verifyEmailRequest, ref List<BusinessLogicException> businessLogicExceptions)
        {
            //Check verifyEmailRequest
            if (verifyEmailRequest == null)
                throw new VerifyEmailRequestIsNullException();
            else
            {
                // Check SsoUserGuid
                if (verifyEmailRequest.SsoUserGuid == Guid.Empty)
                    businessLogicExceptions.Add(new SsoUserGuidInVerifyEmailRequestIsNullException());

                // Check otp
                int otp;
                if (string.IsNullOrEmpty(verifyEmailRequest.Otp))
                    businessLogicExceptions.Add(new EmailOtpIsNullException());

                else if (verifyEmailRequest.Otp.Length != 6)
                    businessLogicExceptions.Add(new EmailOtpLenghtIsInvalidException());
                else
                {
                    Int32.TryParse(verifyEmailRequest.Otp, out otp);
                    if (otp == 0)
                        businessLogicExceptions.Add(new EmailOtpIsInvalidException());
                }

                //Check UserAgent and IPAddress
                ShareParemetersRequest shareParemeters = new ShareParemetersRequest(verifyEmailRequest.UserAgent, verifyEmailRequest.UserIPAddress);
                ShareParemetersInRequestsValidation.Validate(ref shareParemeters);
            }

            return businessLogicExceptions;
        }
    }
}
