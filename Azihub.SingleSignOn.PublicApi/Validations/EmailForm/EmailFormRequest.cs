namespace Azihub.SingleSignOn.PublicApi.Dtos
{
    public class EmailFormRequest
    {
        public EmailFormRequest(string emailAddress, string body)
        {
            EmailAddress = emailAddress;
            Body = body;
        }
        public string EmailAddress { get; set; }
        public string Body { get; set; }
    }
}
