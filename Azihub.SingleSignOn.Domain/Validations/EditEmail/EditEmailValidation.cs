using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Utilities;
using Azihub.SingleSignOn.Domain.Validations.EditEmail.Exceptions;
using Azihub.SingleSignOn.Domain.Validations.ShareParemetersInRequests;
using System;
using System.Collections.Generic;

namespace Azihub.SingleSignOn.Domain.Validations.EditEmail
{
    public static class EditEmailValidation
    {
        /// <summary>
        /// This method wants to check EditEmailRequest.
        /// If any of these items are null or empty, no email should be sent.
        /// An EditEmailFormIsNullException must be thrown if the EditEmailRequest is null.
        /// An SsoUserGuidInEmailFormIsNullExeption must be thrown if the SsoUserGuid is null.
        /// An EmailInEditEmailFormIsNullException must be thrown if the email is null or empty.
        /// An EmailInEditEmailFormIsInvalidException must be thrown if the email is invalid.
        /// </summary>
        /// <param name="editEmailRequest"></param>
        /// <param name="businessLogicExceptions"></param>
        /// <returns></returns>
        public static List<BusinessLogicException> Validate(ref EditEmailRequest editEmailRequest, ref List<BusinessLogicException> businessLogicExceptions)
        {
            //Check editEmailRequest
            if (editEmailRequest == null)
                throw new EditEmailFormIsNullException();
            else
            {
                // Check SsoUserGuid
                if (editEmailRequest.SsoUserGuid == Guid.Empty)
                    businessLogicExceptions.Add(new SsoUserGuidInEmailFormIsNullExeption());

                // Check Email
                var email = editEmailRequest.Email;
                if (string.IsNullOrEmpty(editEmailRequest.Email))
                    businessLogicExceptions.Add(new EmailInEditEmailFormIsNullException());

                // Checks the email is valid
                else if (!RegexUtilities.IsValidEmail(ref email))
                    businessLogicExceptions.Add(new EmailInEditEmailFormIsInvalidException());

                //Check UserAgent and IPAddress
                ShareParemetersRequest shareParemeters = new ShareParemetersRequest(editEmailRequest.UserAgent, editEmailRequest.UserIPAddress);
                ShareParemetersInRequestsValidation.Validate(ref shareParemeters);
            }

            return businessLogicExceptions;
        }
    }
}
