using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.Validations.Mobile;
using Azihub.SingleSignOn.PublicApi.Validations.SendSms.Exceptions;
using Azihub.SingleSignOn.PublicApi.Validations.ShareParemetersInRequests;
using System;
using System.Collections.Generic;

namespace Azihub.SingleSignOn.PublicApi.Validations.SendSms
{
    public static class SendSmsValidation
    {
        public static List<BusinessLogicException> Validate(ref SendSmsRequest sendSmsRequest, ref List<BusinessLogicException> businessLogicExceptions)
        {
            // Check sendSmsRequest
            if (sendSmsRequest == null)
                throw new SendSmsRequestIsNullException();
            else
            {
                // Check SsoUserGuid
                if (sendSmsRequest.SsoUserGuid == Guid.Empty)
                    businessLogicExceptions.Add(new SsoUserGuidInSendSmsRequestIsNullException());

                // Check mobile
                var mobile = sendSmsRequest.Mobile.ToString();

                if (string.IsNullOrEmpty(sendSmsRequest.Mobile))
                    businessLogicExceptions.Add(new MobileInSendSmsRequestIsNullException());

                else if (sendSmsRequest.Mobile == "0")
                    businessLogicExceptions.Add(new MobileInSendSmsRequestIsZerolException());

                else if (!MobileValidation.IsValid(ref mobile))
                    businessLogicExceptions.Add(new MobileInSendSmsRequestIsInvalidException());

                //Check UserAgent and IPAddress
                ShareParemetersRequest shareParemeters = new ShareParemetersRequest(sendSmsRequest.UserAgent, sendSmsRequest.UserIPAddress);
                ShareParemetersInRequestsValidation.Validate(ref shareParemeters);
            }
            return businessLogicExceptions;
        }
    }
}
