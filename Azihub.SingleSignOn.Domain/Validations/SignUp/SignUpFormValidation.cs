using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Utilities;
using Azihub.SingleSignOn.Domain.Validations.Mobile;
using Azihub.SingleSignOn.Domain.Validations.ShareParemetersInRequests;
using Azihub.SingleSignOn.Domain.Validations.SignUp.Exceptions;
using System.Collections.Generic;

namespace Azihub.SingleSignOn.Domain.Validations.SignUp
{
    public static class SignUpFormValidation
    {
        /// <summary>
        /// This method validates SignUpFormRequest.
        /// </summary>
        /// <param name="signUpFormRequest"></param>
        /// <param name="businessLogicExceptions"></param>
        /// <returns></returns>
        public static List<BusinessLogicException> Validate(ref SignUpFormRequest signUpFormRequest, ref List<BusinessLogicException> businessLogicExceptions)
        {

            //Checks that the model is null
            if (signUpFormRequest == null)
                throw new SignUpFormIsNullException();
            else
            {
                //Check FirstName
                FirstNameValidation(signUpFormRequest, businessLogicExceptions);

                //Check LastName
                LastNameValidation(signUpFormRequest, businessLogicExceptions);

                //Check  Password
                PasswordValidation(signUpFormRequest, businessLogicExceptions);

                //Check Email
                EmailValidation(signUpFormRequest, businessLogicExceptions);

                //Check Mobile
                MobileNumberValidation(signUpFormRequest, businessLogicExceptions);

                //Check GdCountryIso2Code
                GdCountryIso2CodeValidation(signUpFormRequest, businessLogicExceptions);

                //Check UserAgent and IPAddress
                ShareParameters(signUpFormRequest);
            }

            return businessLogicExceptions;

        }

        /// <summary>
        /// This is the method for checking the UserAgent and UserIPAddress.
        /// A UserAgentIsNullException is thrown If UserAgent is null,
        /// A UserIPAddressIsNullException is thrown If UserIPAdress is null,
        /// </summary>
        /// <param name="signUpFormRequest"></param>
        /// <param name="signUpFormErrors"></param>
        private static void ShareParameters(SignUpFormRequest signUpFormRequest)
        {
            ShareParemetersRequest shareParemeters = new ShareParemetersRequest(signUpFormRequest.UserAgent, signUpFormRequest.UserIpAddress);
            ShareParemetersInRequestsValidation.Validate(ref shareParemeters);
        }

        /// <summary>
        /// This method checks GdCountryIso2Code.
        ///A GdCountryIso2CodeIsNullException is thrown if GdCountryIso2Code is empty
        /// </summary>
        /// <param name="signUpFormRequest"></param>
        /// <param name="signUpFormErrors"></param>
        private static void GdCountryIso2CodeValidation(SignUpFormRequest signUpFormRequest, ICollection<BusinessLogicException> signUpFormErrors)
        {
            // Checks that the GdCountryIso2Code is null or empty
            if (signUpFormRequest.ResidentCountry == null)
                signUpFormErrors.Add(new GdCountryIso2CodeIsNullException());

        }

        /// <summary>
        /// This is the method for checking the mobile.
        /// If the mobile is null, a MobileNullException is thrown.
        /// Otherwise MobileIsInvalidException will be thrown if the email is not valid.
        /// </summary>
        /// <param name="signUpFormRequest"></param>
        /// <param name="signUpFormErrors"></param>
        private static void MobileNumberValidation(SignUpFormRequest signUpFormRequest, ICollection<BusinessLogicException> signUpFormErrors)
        {
            var mobile = signUpFormRequest.Mobile.ToString();
            // Checks that the mobile is 0
            if (signUpFormRequest.Mobile == 0)
                signUpFormErrors.Add(new MobileIsNullException());

            // Checks the mobile is valid
            else if (!MobileValidation.IsValid(ref mobile))
                signUpFormErrors.Add(new MobileIsInvalidException());
        }

        /// <summary>
        /// This is the method for checking the email.
        /// If the email is null, a EmailNullException is thrown.
        /// Otherwise EmailIsInvalidException will be thrown if the email is not valid.
        /// </summary>
        /// <param name="signUpFormRequest"></param>
        /// <param name="signUpFormErrors"></param>
        private static void EmailValidation(SignUpFormRequest signUpFormRequest, ICollection<BusinessLogicException> signUpFormErrors)
        {
            var email = signUpFormRequest.Email;

            // Checks that the email is null
            if (string.IsNullOrEmpty(signUpFormRequest.Email))
                signUpFormErrors.Add(new EmailIsNullException());

            // Checks the email is valid
            else if (!RegexUtilities.IsValidEmail(ref email))
                signUpFormErrors.Add(new EmailIsInvalidException());

        }

        /// <summary>
        ///  This is the method for checking the password.
        /// If the password is null, a PasswordNullException is thrown.
        /// Otherwise BadPasswordSelectionException will be thrown if the password is not valid.
        /// </summary>
        /// <param name="signUpFormRequest"></param>
        /// <param name="signUpFormErrors"></param>
        private static void PasswordValidation(SignUpFormRequest signUpFormRequest, ICollection<BusinessLogicException> signUpFormErrors)
        {
            var password = signUpFormRequest.Password;
            // Checks that the password is null
            if (string.IsNullOrEmpty(signUpFormRequest.Password))
                signUpFormErrors.Add(new PasswordIsNullException());

            // Checks the password is valid
            else if (!RegexUtilities.IsValidPassword(ref password))
                signUpFormErrors.Add(new PasswordExceptions());
        }

        /// <summary>
        /// This is the method for checking the lastname.
        /// If the lastname is null, a LastNameNullException is thrown.
        /// Otherwise check that the number of characters in the lastname is not less than the minimum number of characters.Otherwise ShortLastNameSelectException will thrown.
        /// Otherwise check that the number of characters in the lastname is not less than the maximum number of characters. Otherwise LongLastNameSelectException will thrown.
        /// </summary>
        /// <param name="signUpFormRequest"></param>
        /// <param name="signUpFormErrors"></param>
        private static void LastNameValidation(SignUpFormRequest signUpFormRequest, ICollection<BusinessLogicException> signUpFormErrors)
        {
            // Checks that the lastname is null
            if (string.IsNullOrEmpty(signUpFormRequest.LastName))
                signUpFormErrors.Add(new LastNameIsNullException());

            // Checks the minimum characters of lastname
            else if (signUpFormRequest.LastName.Length < signUpFormRequest.GetMinLength("LastName"))
                signUpFormErrors.Add(new LastNameIsShortException());

            // Checks the maximum characters of lastname
            else if (signUpFormRequest.LastName.Length > signUpFormRequest.GetMaxLength("LastName"))
                signUpFormErrors.Add(new LastNameIsLongException());
        }

        /// <summary>
        /// This is the method for checking the firstname.
        /// If the firstname is null, a FirstNameNullException is thrown.
        /// Otherwise check that the number of characters in the firstname is not less than the minimum number of characters.Otherwise ShortFirstNameSelectException will thrown.
        /// Otherwise check that the number of characters in the firstname is not less than the maximum number of characters. Otherwise LongFirstNameSelectException will thrown.
        /// </summary>
        /// <param name="signUpFormRequest"></param>
        /// <param name="signUpFormErrors"></param>
        private static void FirstNameValidation(SignUpFormRequest signUpFormRequest, ICollection<BusinessLogicException> signUpFormErrors)
        {
            // Checks that the firstname is null
            if (string.IsNullOrEmpty(signUpFormRequest.FirstName))
                signUpFormErrors.Add(new FirstNameIsNullException());

            // Checks the minimum characters of firstname
            else if (signUpFormRequest.FirstName.Length < signUpFormRequest.GetMinLength("FirstName"))
                signUpFormErrors.Add(new FirstNameIsShortException());

            // Checks the maximum characters of firstname
            else if (signUpFormRequest.FirstName.Length > signUpFormRequest.GetMaxLength("FirstName"))
                signUpFormErrors.Add(new FirstNameIsLongException());
        }


    }
}
