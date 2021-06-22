namespace Azihub.SingleSignOn.Domain.Validations.ShareParemetersInRequests
{
    public class ShareParemetersRequest
    {
        public ShareParemetersRequest(string userAgent, string iPAddress)
        {
            UserAgent = userAgent;
            UserIPAddress = iPAddress;

        }
        public string UserAgent { get; set; }
        public string UserIPAddress { get; set; }
    }
}
