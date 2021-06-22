using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Validations.ShareParemetersInRequests;
using Azihub.SingleSignOn.Domain.Validations.VerifyMobileOtp.Exceptions;
using System;
using System.Collections.Generic;

namespace Azihub.SingleSignOn.Domain.Validations.VerifyMobileOtp
{
    public static class VerifyMobileOtpValidation
    {
        /// <summary>
        /// This method wants to check the SsoUserGuid and otp.
        /// If any of these items are null or empty, mobile will not be verified.
        /// An VerifyMobileOtpRequestIsNullException must be thrown if the verifyMobileOtpRequest is null.
        /// An SsoUserGuidInVerifyMobileOtpRequestIsNullException must be thrown if the SsoUserGuid is null or empty.
        /// An MobileOtpIsNullException must be thrown if the otp is null.
        /// An MobileOtpLenghtIsInvalidException must be thrown if the otp lenght is invalid.
        /// An InvalidMobileOtpException must be thrown if the otp is invalid.
        /// </summary>
        /// <param name="verifyMobileOtpRequest"></param>
        /// <param name="businessLogicExceptions"></param>
        /// <returns></returns>
        public static List<BusinessLogicException> Validate(ref VerifyMobileOtpRequest verifyMobileOtpRequest, ref List<BusinessLogicException> businessLogicExceptions)
        {
            //Check verifyMobileOtpRequest
            if (verifyMobileOtpRequest == null)
                throw new VerifyMobileOtpRequestIsNullException();
            else
            {
                // Check SsoUserGuid
                if (verifyMobileOtpRequest.SsoUserGuid == Guid.Empty)
                    businessLogicExceptions.Add(new SsoUserGuidInVerifyMobileOtpRequestIsNullException());

                // Check otp
                int otp;
                if (string.IsNullOrEmpty(verifyMobileOtpRequest.Otp))
                    businessLogicExceptions.Add(new MobileOtpIsNullException());

                else if (verifyMobileOtpRequest.Otp.Length != 6)
                    businessLogicExceptions.Add(new MobileOtpLenghtIsInvalidException());
                else
                {
                    Int32.TryParse(verifyMobileOtpRequest.Otp, out otp);
                    if (otp == 0)
                        businessLogicExceptions.Add(new MobileOtpIsInvalidException());
                }

                //Check UserAgent and IPAddress
                ShareParemetersRequest shareParemeters = new ShareParemetersRequest(verifyMobileOtpRequest.UserAgent, verifyMobileOtpRequest.UserIPAddress);
                ShareParemetersInRequestsValidation.Validate(ref shareParemeters);
            }

            return businessLogicExceptions;
        }
    }
}
