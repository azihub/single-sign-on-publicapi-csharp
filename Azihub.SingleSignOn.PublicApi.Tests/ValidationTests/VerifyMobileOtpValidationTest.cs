using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.DemoData;
using Azihub.SingleSignOn.PublicApi.Validations.VerifyMobileOtp;
using Azihub.SingleSignOn.PublicApi.Validations.VerifyMobileOtp.Exceptions;
using Xunit;

namespace Azihub.SingleSignOn.PublicApi.Tests.ValidationTests
{
    public class VerifyMobileOtpValidationTest : ValidationBaseTest
    {
        /// <summary>
        /// If VerifyMobileOtpRequest was null, VerifyMobileOtpRequestIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyMobileOtpValidation_When_VerifyMobileOtpRequest_Is_Null_Throw_VerifyMobileOtpRequestIsNullException()
        {
            // Act-Assert
            Assert.Throws<VerifyMobileOtpRequestIsNullException>((() => VerifyMobileOtpValidation.Validate(ref SsoTestDataSet.VerifyMobileOtpRequestIsNull, ref SignUpFormErrors)));
        }

        /// <summary>
        /// If SsoUserGuid was null, SsoUserGuidInVerifyMobileOtpRequestIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyMobileOtpValidation_When_SsoUserGuid_Is_Null_Throw_SsoUserGuidInVerifyMobileOtpRequestIsNullException()
        {
            // Act-Assert
            var result = VerifyMobileOtpValidation.Validate(ref SsoTestDataSet.SsoUserGuidInVerifyMobileOtpRequestIsNull, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new SsoUserGuidInVerifyMobileOtpRequestIsNullException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If otp was empty, MobileOtpIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyMobileOtpValidation_When_Otp_Is_Empty_Throw_MobileOtpIsNullException()
        {
            // Act-Assert
            var result = VerifyMobileOtpValidation.Validate(ref SsoTestDataSet.OtpInVerifyMobileOtpRequestIsEmpty, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new MobileOtpIsNullException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If otp lenght was invalid, MobileOtpLenghtIsInvalidException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyMobileOtpValidation_When_Otp_Lenght_Is_Invalid_Throw_MobileOtpLenghtIsInvalidException()
        {
            // Act-Assert
            var result = VerifyMobileOtpValidation.Validate(ref SsoTestDataSet.OtpLenghtInVerifyMobileOtpRequestIsInvalid, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new MobileOtpLenghtIsInvalidException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If otp was invalid, InvalidMobileOtpException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyMobileOtpValidation_When_Otp_Is_Invalid_Throw_InvalidMobileOtpException()
        {
            // Act-Assert
            var result = VerifyMobileOtpValidation.Validate(ref SsoTestDataSet.OtpInVerifyMobileOtpRequestIsInvalid, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new MobileOtpIsInvalidException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If SsoUserGuid and otp were null, SsoUserGuidInVerifyMobileOtpRequestIsNullException, MobileOtpIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyMobileOtpValidation_When_SsoUserGuid_And_Otp_Are_Null_Throw_SsoUserGuidInVerifyMobileOtpRequestIsNullException_And_MobileOtpIsNullException()
        {
            // Act-Assert
            var result = VerifyMobileOtpValidation.Validate(ref SsoTestDataSet.SsoUserGuidAndOtpInVerifyMobileOtpRequestAreNull, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new SsoUserGuidInVerifyMobileOtpRequestIsNullException(), new MobileOtpIsNullException() };

            Assert.Equal(2, result.Count);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
            Assert.Equal(errors[1].Message, result[1].Message);
            Assert.Equal(errors[1].Code, result[1].Code);
        }

        /// <summary>
        /// If SsoUserGuid was null and otp was invalid lenght, SsoUserGuidInVerifyMobileOtpRequestIsNullException, MobileOtpLenghtIsInvalidException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyMobileOtpValidation_When_SsoUserGuid_Is_Null_And_Otp_Is_Invalid_Lenght_Throw_SsoUserGuidInVerifyMobileOtpRequestIsNullException_And_MobileOtpLenghtIsInvalidException()
        {
            // Act-Assert
            var result = VerifyMobileOtpValidation.Validate(ref SsoTestDataSet.SsoUserGuidIsNullAndOtpIsInvalidLenghtInVerifyMobileOtpRequest, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new SsoUserGuidInVerifyMobileOtpRequestIsNullException(), new MobileOtpLenghtIsInvalidException() };

            Assert.Equal(2, result.Count);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
            Assert.Equal(errors[1].Message, result[1].Message);
            Assert.Equal(errors[1].Code, result[1].Code);
        }

        /// <summary>
        /// If SsoUserGuid was null and otp was invalid , SsoUserGuidInVerifyMobileOtpRequestIsNullException, InvalidMobileOtpException must be thrown.
        /// </summary>
        [Fact]
        public void VerifyMobileOtpValidation_When_SsoUserGuid_Is_Null_And_Otp_Is_Invalid_Throw_SsoUserGuidInVerifyMobileOtpRequestIsNullException_And_InvalidMobileOtpException()
        {
            // Act-Assert
            var result = VerifyMobileOtpValidation.Validate(ref SsoTestDataSet.SsoUserGuidIsNullAndOtpIsInvalidInVerifyMobileOtpRequest, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new SsoUserGuidInVerifyMobileOtpRequestIsNullException(), new MobileOtpIsInvalidException() };

            Assert.Equal(2, result.Count);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
            Assert.Equal(errors[1].Message, result[1].Message);
            Assert.Equal(errors[1].Code, result[1].Code);
        }

        /// <summary>
        /// If VerifyMobileOtpRequest was Ok, Exception count is 0.
        /// </summary>
        [Fact]
        public void VerifyMobileOtpValidation_When_VerifyMobileOtpRequest_Is_Ok_Exception_Count_Is_0()
        {
            // Act-Assert
            var result = VerifyMobileOtpValidation.Validate(ref SsoTestDataSet.VerifyMobileOtpRequestIsOk, ref SignUpFormErrors);

            Assert.Empty(result);
        }

    }
}
