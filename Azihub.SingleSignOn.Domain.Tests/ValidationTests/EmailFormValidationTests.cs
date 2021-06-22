using Azihub.SingleSignOn.Domain.DemoData;
using Azihub.SingleSignOn.Domain.Validations.EmailForm;
using Azihub.SingleSignOn.Domain.Validations.EmailForm.Exceptions;
using Xunit;

namespace Azihub.SingleSignOn.Domain.Tests.ValidationTests
{
    public class EmailFormValidationTests : ValidationBaseTest
    {
        /// <summary>
        /// If EamilFormRequest was null, EmailFormIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void EmailFormValidation_When_EamilFormRequest_Is_Null_Throw_EmailFormIsNullException()
        {
            // Act-Assert
            Assert.Throws<EmailFormIsNullException>((() => EmailFormValidation.Validate(ref SsoTestDataSet.EamilFormNull)));
        }

        /// <summary>
        /// If EmailAddress was empty, EmailAddressIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void EmailFormValidation_When_EmailAddress_Is_Empty_Throw_EmailAddressIsNullException()
        {
            // Act-Assert
            Assert.Throws<EmailAddressIsNullException>((() => EmailFormValidation.Validate(ref SsoTestDataSet.EamilFormWithEmptyEmailAddress)));
        }


        /// <summary>
        /// If Body was empty, EmailBodyIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void EmailFormValidation_When_Body_Is_Empty_Throw_EmailBodyIsNullException()
        {
            // Act-Assert
            Assert.Throws<EmailBodyIsNullException>((() => EmailFormValidation.Validate(ref SsoTestDataSet.EamilFormWithEmptyBody)));
        }

    }
}
