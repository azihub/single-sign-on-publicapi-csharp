using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.SignUp.Exceptions
{
    public class SignUpFormException : BusinessLogicException
    {
        public SignUpFormException()
        {

        }

        public SignUpFormException(string x)
        {

        }
        /// <summary>
        /// Pass array of errors when form submit is initiated by MVC Project 
        /// </summary>
        /// <param name="errors"></param>
        public SignUpFormException(BusinessLogicException[] errors)
        {
            Errors = errors;
        }
        public override int Code { get; } = (int)ErrorCodes.SignUpForm;
        public override string LocaleConst => LocaleConsts.SIGNUP_FORM_FAILED;
    }

}
