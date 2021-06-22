namespace Azihub.SingleSignOn.Domain.KnowYourCustomer.KycApplication
{
    public class NationalId : VerifiableDocument
    {
        private NationalId()
        {

        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <param name="front"></param>
        /// <param name="back"></param>
        public NationalId(Image front, Image back)
        {
            Front = front;
            Back = back;
        }
        public Image Front { get; set; }
        public Image Back { get; set; }
    }
}