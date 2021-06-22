using Azihub.SingleSignOn.Domain.DemoData;
using Azihub.SingleSignOn.Domain.Validations.SignUp.Exceptions;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Azihub.SingleSignOn.Domain.Utilities
{
    public static class GenerateUtilities
    {
        /// <summary>
        /// This method takes a password and hashes it.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string GenerateHashPassword(ref string password)
        {
            // Check password is null or empty
            if (string.IsNullOrEmpty(password))
                throw new PasswordIsNullException();

            // Initialize a SHA256 hash object.
            using SHA256 sha256Hash = SHA256.Create();

            // Compute the hash of string
            var dataHash = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder hashPassword = new StringBuilder();

            // Create hash password
            foreach (var t in dataHash)
            {
                hashPassword.Append(t.ToString("x2"));
            }

            //Return hash password
            return hashPassword.ToString();
        }

        /// <summary>
        /// This method generates an otp.
        /// This otp is used to send email or SMS.
        /// </summary>
        /// <returns></returns>
        public static string GenerateOtp()
        {
#if DEBUG
            // Generate Otp in test mode
            return SsoTestDataSet.SSOOTP_TEST;
#endif
            //Otp lenght
            int otpLenght = 6;
            StringBuilder stringBuilder = new StringBuilder();

            //Generate random otp
            Random random = new Random();
            while (0 < otpLenght--)
            {
                stringBuilder.Append("1234567890"[random.Next("1234567890".Length)]);
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// This method generates a SsoUserGuid code.
        /// If we are in test mode, a predefined SsoUserGuid will be return.
        /// In test mode, we must pass a true to the method input.
        /// </summary>
        /// <param name="isTestMode"></param>
        /// <returns></returns>
        public static Guid GenerateSsoUserGuid()
        {
            // Generate ssoUserGuid in app mode
            Guid generateSsoUserGuid = Guid.NewGuid();
#if DEBUG
            // Generate ssoUserGuid in test mode
            generateSsoUserGuid = Guid.Parse(SsoDemoData.SSO_USER_JOHN_DOE_GUID);
#endif
            return generateSsoUserGuid;
        }

        /// <summary>
        /// This method generates a EmailToken .
        /// If we are in test mode, a predefined EmailToken will be return.
        /// In test mode, we must pass a true to the method input.
        /// </summary>
        /// <param name="isTestMode"></param>
        /// <returns></returns>
        public static Guid GenerateVerifyEmailToken()
        {
            // Generate EmailToken in app mode
            Guid generateEmailToken = Guid.NewGuid();
#if DEBUG
            // Generate EmailToken in test mode
            generateEmailToken = Guid.Parse(SsoDemoData.SSO_EMAIL_TOKEN_JOHN_DOE_EMAIL_TOKEN);
#endif
            return generateEmailToken;
        }

    }
}
