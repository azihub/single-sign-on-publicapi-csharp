namespace Azihub.SingleSignOn.PublicApi.Validations.Exceptions.VerifyMobileOtpExceptions
{
    public class VerifyMobileOtpRequestIsNullException: MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.VerifyMobileOtpRequestIsNull;
    }
}
