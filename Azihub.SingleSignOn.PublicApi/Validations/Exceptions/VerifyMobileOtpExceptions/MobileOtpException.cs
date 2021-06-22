using Azihub.AppConsole.Base.Exceptions;

namespace Azihub.SingleSignOn.PublicApi.Validations.Exceptions.VerifyMobileOtpExceptions
{
    public class MobileOtpException : BusinessLogicException
    {
        public MobileOtpException()
        {
        }

        /// <summary>
        /// Pass array of errors when form submit is initiated by MVC Project 
        /// </summary>
        /// <param name="errors"></param>
        public MobileOtpException(BusinessLogicException[] errors)
        {
            Errors = errors;
        }
        public override int Code { get; } = (int)ErrorCodes.VerifyMobileOtp;

        public override string LocaleConst => throw new System.NotImplementedException();
    }
}
