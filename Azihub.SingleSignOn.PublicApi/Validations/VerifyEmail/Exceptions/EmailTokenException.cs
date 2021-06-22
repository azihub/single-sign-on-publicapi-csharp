using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.Locales;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyEmail.Exceptions
{
    public class EmailTokenException : BusinessLogicException
    {
        public EmailTokenException()
        {
        }

        /// <summary>
        /// Pass array of errors when form submit is initiated by MVC Project 
        /// </summary>
        /// <param name="errors"></param>
        public EmailTokenException(BusinessLogicException[] errors)
        {
            Errors = errors;
        }
        public override int Code { get; } = (int)ErrorCodes.VerifyEmail;
        public override string LocaleConst => LocaleConsts.EMAIL_TOKEN_FAILED;

    }
}