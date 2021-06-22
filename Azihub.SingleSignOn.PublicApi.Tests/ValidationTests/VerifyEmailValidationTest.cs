using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.DemoData;
using Azihub.SingleSignOn.PublicApi.Validations.VerifyEmail;
using Azihub.SingleSignOn.PublicApi.Validations.VerifyEmail.Exceptions;
using Xunit;

namespace Azihub.SingleSignOn.PublicApi.Tests.ValidationTests
{
    public class VerifyEmailValidationTest : ValidationBaseTest
    {
        /// <summary>
        /// If VerifyEmailRequest was null, VerifyEmailRequestIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyEmailValidation_When_VerifyEmailRequest_Is_Null_Throw_VerifyEmailRequestIsNullException()
        {
            // Act-Assert
            Assert.Throws<VerifyEmailRequestIsNullException>((() => VerifyEmailValidation.Validate(ref SsoTestDataSet.VerifyEmailRequestIsNull, ref SignUpFormErrors)));
        }

        /// <summary>
        /// If SsoUserGuid was null, SsoUserGuidInVerifyEmailRequestIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyEmailValidation_When_SsoUserGuid_Is_Null_Throw_SsoUserGuidInVerifyEmailRequestIsNullException()
        {
            // Act-Assert
            var result = VerifyEmailValidation.Validate(ref SsoTestDataSet.SsoUserGuidInVerifyEmailRequestIsNull, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new SsoUserGuidInVerifyEmailRequestIsNullException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If otp was empty, EmailOtpIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyEmailValidation_When_Otp_Is_Empty_Throw_EmailOtpIsNullException()
        {
            // Act-Assert
            var result = VerifyEmailValidation.Validate(ref SsoTestDataSet.OtpInVerifyEmailRequestIsEmpty, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new EmailOtpIsNullException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If otp lenght was invalid, EmailOtpLenghtIsInvalidException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyEmailValidation_When_Otp_Lenght_Is_Invalid_Throw_EmailOtpLenghtIsInvalidException()
        {
            // Act-Assert
            var result = VerifyEmailValidation.Validate(ref SsoTestDataSet.OtpLenghtInVerifyEmailRequestIsInvalid, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new EmailOtpLenghtIsInvalidException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If otp was invalid, InvalidEmailOtpException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyEmailValidation_When_Otp_Is_Invalid_Throw_InvalidEmailOtpException()
        {
            // Act-Assert
            var result = VerifyEmailValidation.Validate(ref SsoTestDataSet.OtpInVerifyEmailRequestIsInvalid, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new EmailOtpIsInvalidException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If SsoUserGuid and otp were null, SsoUserGuidInVerifyEmailRequestIsNullException, EmailOtpIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyEmailValidation_When_SsoUserGuid_And_Otp_Are_Null_Throw_SsoUserGuidInVerifyEmailRequestIsNullException_And_EmailOtpIsNullException()
        {
            // Act-Assert
            var result = VerifyEmailValidation.Validate(ref SsoTestDataSet.SsoUserGuidAndOtpInVerifyEmailRequestAreNull, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new SsoUserGuidInVerifyEmailRequestIsNullException(), new EmailOtpIsNullException() };

            Assert.Equal(2, result.Count);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
            Assert.Equal(errors[1].Message, result[1].Message);
            Assert.Equal(errors[1].Code, result[1].Code);
        }

        /// <summary>
        /// If SsoUserGuid was null and otp was invalid lenght, SsoUserGuidInVerifyEmailRequestIsNullException, EmailOtpLenghtIsInvalidException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyEmailValidation_When_SsoUserGuid_Is_Null_And_Otp_Is_Invalid_Lenght_Throw_SsoUserGuidInVerifyEmailRequestIsNullException_And_EmailOtpLenghtIsInvalidException()
        {
            // Act-Assert
            var result = VerifyEmailValidation.Validate(ref SsoTestDataSet.SsoUserGuidIsNullAndOtpIsInvalidLenghtInVerifyEmailRequest, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new SsoUserGuidInVerifyEmailRequestIsNullException(), new EmailOtpLenghtIsInvalidException() };

            Assert.Equal(2, result.Count);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
            Assert.Equal(errors[1].Message, result[1].Message);
            Assert.Equal(errors[1].Code, result[1].Code);
        }

        /// <summary>
        /// If SsoUserGuid was null and otp was invalid , SsoUserGuidInVerifyEmailRequestIsNullException, InvalidEmailOtpException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyEmailValidation_When_SsoUserGuid_Is_Null_And_Otp_Is_Invalid_Throw_SsoUserGuidInVerifyEmailRequestIsNullException_And_InvalidEmailOtpException()
        {
            // Act-Assert
            var result = VerifyEmailValidation.Validate(ref SsoTestDataSet.SsoUserGuidIsNullAndOtpIsInvalidInVerifyEmailRequest, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new SsoUserGuidInVerifyEmailRequestIsNullException(), new EmailOtpIsInvalidException() };

            Assert.Equal(2, result.Count);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
            Assert.Equal(errors[1].Message, result[1].Message);
            Assert.Equal(errors[1].Code, result[1].Code);
        }

        /// <summary>
        /// If VerifyEmailRequest was Ok, Exception count is 0.
        /// </summary>
        [Fact]
        public void VerifyEmailValidation_When_VerifyEmailRequest_Is_Ok_Exception_Count_Is_0()
        {
            // Act-Assert
            var result = VerifyEmailValidation.Validate(ref SsoTestDataSet.VerifyEmailRequestIsOk, ref SignUpFormErrors);

            Assert.Empty(result);
        }

    }
}
