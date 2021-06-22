using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.DemoData;
using Azihub.SingleSignOn.PublicApi.Validations.EditEmail;
using Azihub.SingleSignOn.PublicApi.Validations.EditEmail.Exceptions;
using Xunit;

namespace Azihub.SingleSignOn.PublicApi.Tests.ValidationTests
{
    public class EditEmailValidationTests : ValidationBaseTest
    {
        /// <summary>
        /// If EamilFormRequest was null, EditEmailFormIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void EditEmailValidation_When_EditEmailRequest_Is_Null_Throw_EditEmailFormIsNullException()
        {
            // Act-Assert
            Assert.Throws<EditEmailFormIsNullException>((() => EditEmailValidation.Validate(ref SsoTestDataSet.EditEmailRequestNull, ref SignUpFormErrors)));
        }

        /// <summary>
        /// If ssoUserGuid was empty, SsoUserGuidInEmailFormIsNullExeption must be thrown.
        /// </summary>
        [Fact]
        public void EditEmailValidation_When_SsoUserGuid_Is_Null_Throw_SsoUserGuidInEmailFormIsNullExeption()
        {
            // Act-Assert
            var result = EditEmailValidation.Validate(ref SsoTestDataSet.SsoUserGuidInEditEmailRequestIsEmpty, ref SignUpFormErrors);
            var errors = new BusinessLogicException[] { new SsoUserGuidInEmailFormIsNullExeption() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If email was null, EmailInEditEmailFormIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void EditEmailValidation_When_Email_Is_Null_Throw_EmailInEditEmailFormIsNullException()
        {
            // Act-Assert
            var result = EditEmailValidation.Validate(ref SsoTestDataSet.EmailInEditEmailRequestIsNull, ref SignUpFormErrors);
            var errors = new BusinessLogicException[] { new EmailInEditEmailFormIsNullException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If email was empty, EmailInEditEmailFormIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void EditEmailValidation_When_Email_Is_Empty_Throw_EmailInEditEmailFormIsNullException()
        {
            // Act-Assert
            var result = EditEmailValidation.Validate(ref SsoTestDataSet.EmailInEditEmailRequestIsEmpty, ref SignUpFormErrors);
            var errors = new BusinessLogicException[] { new EmailInEditEmailFormIsNullException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If email was invalid, EmailInEditEmailFormIsInvalidException must be thrown.
        /// </summary>
        [Fact]
        public void EditEmailValidation_When_Email_Is_Invalid_Throw_EmailInEditEmailFormIsInvalidException()
        {
            // Act-Assert
            var result = EditEmailValidation.Validate(ref SsoTestDataSet.EmailInEditEmailRequestIsInvalid, ref SignUpFormErrors);
            var errors = new BusinessLogicException[] { new EmailInEditEmailFormIsInvalidException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If email  and ssouserguid were empty, EmailInEditEmailFormIsInvalidException must be thrown.
        /// </summary>
        [Fact]
        public void EditEmailValidation_When_Email_Is_Empty_And_SsoUserGuid_Is_Empty_Throw_EmailInEditEmailFormIsInvalidException()
        {
            // Act-Assert
            var result = EditEmailValidation.Validate(ref SsoTestDataSet.EditEmailRequestEmpty, ref SignUpFormErrors);
            var errors = new BusinessLogicException[] { new SsoUserGuidInEmailFormIsNullExeption(), new EmailInEditEmailFormIsNullException() };

            Assert.Equal(2, result.Count);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
            Assert.Equal(errors[1].Message, result[1].Message);
            Assert.Equal(errors[1].Code, result[1].Code);
        }
    }
}
