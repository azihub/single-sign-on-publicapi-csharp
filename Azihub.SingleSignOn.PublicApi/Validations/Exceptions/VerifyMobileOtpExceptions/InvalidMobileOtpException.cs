namespace Azihub.SingleSignOn.PublicApi.Validations.Exceptions.VerifyMobileOtpExceptions
{
    public class InvalidMobileOtpException: MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.InvalidMobileOtp;
    }
}
