using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.Locales;

namespace Azihub.SingleSignOn.Domain.Validations.EditEmail.Exceptions
{
    public class EditEmailFormException : BusinessLogicException
    {
        public EditEmailFormException()
        {
        }

        /// <summary>
        /// Pass array of errors when form submit is initiated by MVC Project 
        /// </summary>
        /// <param name="errors"></param>
        public EditEmailFormException(BusinessLogicException[] errors)
        {
            Errors = errors;
        }
        public override int Code { get; } = (int)ErrorCodes.EditEmailForm;
        public override string LocaleConst => LocaleConsts.EDIT_EMAIL_FAILED;
    }
}
