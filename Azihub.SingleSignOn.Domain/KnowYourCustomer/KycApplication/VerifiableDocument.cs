namespace Azihub.SingleSignOn.Domain.KnowYourCustomer.KycApplication
{
    public abstract class VerifiableDocument
    {
        public VerificationStatus VerificationStatus { get; } = VerificationStatus.Pending;
    }
}