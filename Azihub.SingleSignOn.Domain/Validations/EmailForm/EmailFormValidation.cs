using Azihub.SingleSignOn.Domain.Dtos;
using Azihub.SingleSignOn.Domain.Validations.EmailForm.Exceptions;

namespace Azihub.SingleSignOn.Domain.Validations.EmailForm
{
    public static class EmailFormValidation
    {
        /// <summary>
        /// This method wants to check the recipient's email address, the text of the email or its title.
        /// If any of these items are null or empty, no email should be sent.
        /// An EmailFormIsNullException must be thrown if the requisition is empty.
        /// An emailAddressIsNullException must be thrown if the email address is empty.
        /// An EmailSubjectIsNullException must be thrown if the email address is null or empty.
        /// An EmailBodyIsNullException must be thrown if the email body is null or  empty.
        /// </summary>
        /// <param name="emailFormRequest"></param>
        /// <returns></returns>
        public static void Validate(ref EmailFormRequest emailFormRequest)
        {
            // Check emailFormRequest
            if (emailFormRequest == null)
                throw new EmailFormIsNullException();

            // Check EmailAddress
            if (string.IsNullOrEmpty(emailFormRequest.EmailAddress))
                throw new EmailAddressIsNullException();

            // Check Body
            if (string.IsNullOrEmpty(emailFormRequest.Body))
                throw new EmailBodyIsNullException();
        }
    }
}
