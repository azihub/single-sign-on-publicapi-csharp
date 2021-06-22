using System.Text.RegularExpressions;

namespace Azihub.SingleSignOn.Domain.Utilities
{
    public static class RegexUtilities
    {
        /// <summary>
        /// This method checks to see if the email is valid or not.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(ref string email)
        {
            // Check validate email if it is not null or empty
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                //Check email
                Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                return emailRegex.IsMatch(email);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

        }

        /// <summary>
        /// This method checks to see if the password is valid or not.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool IsValidPassword(ref string password)
        {
            // Check validate password if it is not null or empty
            if (string.IsNullOrWhiteSpace(password))
                return false;

            try
            {
                // Check password
                var passwordRegx = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

                return passwordRegx.IsMatch(password);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
