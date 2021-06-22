namespace Azihub.SingleSignOn.PublicApi.KnowYourCustomer.KycApplication
{
    public abstract class VerifiableDocument
    {
        public VerificationStatus VerificationStatus { get; } = VerificationStatus.Pending;
    }
}