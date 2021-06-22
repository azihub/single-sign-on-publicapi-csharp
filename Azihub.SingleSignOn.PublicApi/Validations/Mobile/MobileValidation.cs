using Arzshomar.Domain.Validations.Mobile.Exceptions;
using PhoneNumbers;

namespace Azihub.SingleSignOn.PublicApi.Validations.Mobile
{
    public static class MobileValidation
    {

        /// <summary>
        /// This method checks if the mobile number is valid.
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public static bool IsValid(ref string mobile)
        {
            try
            {
                string phoneNumber = $"+{mobile}";
                PhoneNumberUtil libPhoneNumber = PhoneNumberUtil.GetInstance();

                //Parse Number
                PhoneNumber parsedNumber = libPhoneNumber.Parse(phoneNumber, null);
                string regionCode = libPhoneNumber.GetRegionCodeForNumber(parsedNumber);
                libPhoneNumber.Parse(phoneNumber, regionCode);

                //Spec type
                PhoneNumberType type = libPhoneNumber.GetNumberType(parsedNumber);

                //Check mobile 
                if (type == PhoneNumberType.FIXED_LINE_OR_MOBILE || type == PhoneNumberType.MOBILE)
                    return true;

                return false;
            }
            catch (NumberParseException)
            {
                throw new InvalidEnum164NumberFormatException(/*"Invalid E.164 format was supplied."*/);
            }
        }
    }
}
