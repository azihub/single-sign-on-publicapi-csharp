namespace Azihub.SingleSignOn.PublicApi.Validations.Exceptions.VerifyMobileOtpExceptions
{
    public class SsoUserGuidInVerifyMobileOtpRequestIsInvalidException: MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.SsoUserGuidInVerifyMobileOtpRequestIsInvalid;
    }
}
