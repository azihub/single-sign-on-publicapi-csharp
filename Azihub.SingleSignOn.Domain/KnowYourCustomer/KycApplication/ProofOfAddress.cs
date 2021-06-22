namespace Azihub.SingleSignOn.Domain.KnowYourCustomer.KycApplication
{
    public class ProofOfAddress
    {
        public Image[] Pages { get; set; }
        public ProofOfAddressType Type { get; set; }
    }
}