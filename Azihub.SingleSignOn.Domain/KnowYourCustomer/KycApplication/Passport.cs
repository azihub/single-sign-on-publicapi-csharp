using System;

namespace Azihub.SingleSignOn.Domain.KnowYourCustomer.KycApplication
{
    public class Passport : VerifiableDocument
    {
        public DateTime Id { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Image FirstPage { get; set; }
    }
}