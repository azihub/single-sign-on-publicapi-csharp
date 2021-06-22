namespace Azihub.SingleSignOn.Domain.Validations.Exceptions.VerifyMobileOtpExceptions
{
    public class SsoUserGuidInVerifyMobileOtpRequestIsNullException: MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.SsoUserGuidInVerifyMobileOtpRequestIsNull;
    }
}
