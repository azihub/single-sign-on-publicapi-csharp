using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.DemoData;
using Azihub.SingleSignOn.Domain.Validations.SendSms;
using Azihub.SingleSignOn.Domain.Validations.SendSms.Exceptions;
using Xunit;

namespace Azihub.SingleSignOn.Domain.Tests.ValidationTests
{
    public class SendSmsValidationTests : ValidationBaseTest
    {
        /// <summary>
        /// If SendSmsRequest was null, SendSmsRequestIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void SendSmsValidation_When_SendSmsRequest_Is_Null_Throw_SendSmsRequestIsNullException()
        {
            // Act-Assert
            Assert.Throws<SendSmsRequestIsNullException>((() => SendSmsValidation.Validate(ref SsoTestDataSet.SendSmsWhenSendSmsRequestIsNull, ref SignUpFormErrors)));
        }

        /// <summary>
        /// If SsoUserGuid was null, SsoUserGuidInSendSmsRequestIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void SendSmsValidation_When_SsoUserGuid_Is_Null_Throw_SsoUserGuidInSendSmsRequestIsNullException()
        {
            // Act-Assert
            var result = SendSmsValidation.Validate(ref SsoTestDataSet.SsoUserGuidInSendSmsRequestIsNull, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new SsoUserGuidInSendSmsRequestIsNullException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If mobile was empty, MobileInSendSmsRequestIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void SendSmsValidation_When_Mobile_Is_Empty_Throw_MobileInSendSmsRequestIsNullException()
        {
            // Act-Assert
            var result = SendSmsValidation.Validate(ref SsoTestDataSet.MobileInSendSmsRequestIsEmpty, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new MobileInSendSmsRequestIsNullException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If mobile was Zero, MobileInSendSmsRequestIsZerolException must be thrown.
        /// </summary>
        [Fact]
        public void SendSmsValidation_When_Mobile_Is_Zero_Throw_MobileInSendSmsRequestIsZerolException()
        {
            // Act-Assert
            var result = SendSmsValidation.Validate(ref SsoTestDataSet.MobileInSendSmsRequestIsZero, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new MobileInSendSmsRequestIsZerolException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If mobile was Invalid, MobileInSendSmsRequestIsInvalidException must be thrown.
        /// </summary>
        [Fact]
        public void SendSmsValidation_When_Mobile_Is_Invalid_Throw_MobileInSendSmsRequestIsInvalidException()
        {
            // Act-Assert
            var result = SendSmsValidation.Validate(ref SsoTestDataSet.MobileInSendSmsRequestIsInvalid, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new MobileInSendSmsRequestIsInvalidException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If SsoUserGuid and mobile were null, SsoUserGuidInSendSmsRequestIsNullException, MobileInSendSmsRequestIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void SendSmsValidation_When_SsoUserGuid_And_Mobile_Are_Null_Throw_SsoUserGuidInVerifyEmailRequestIsNullException_And_MobileInSendSmsRequestIsNullException()
        {
            // Act-Assert
            var result = SendSmsValidation.Validate(ref SsoTestDataSet.SsoUserGuidAndMobileAreNullInSendSmsRequest, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new SsoUserGuidInSendSmsRequestIsNullException(), new MobileInSendSmsRequestIsNullException() };

            Assert.Equal(2, result.Count);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
            Assert.Equal(errors[1].Message, result[1].Message);
            Assert.Equal(errors[1].Code, result[1].Code);
        }

        /// <summary>
        /// If SsoUserGuid was null and mobile was zero, SsoUserGuidInSendSmsRequestIsNullException, MobileInSendSmsRequestIsZerolException must be thrown.
        /// </summary>
        [Fact]
        public void SendSmsValidation_When_SsoUserGuid_Is_Null_And_Mobile_Is_Zero_Throw_SsoUserGuidInVerifyEmailRequestIsNullException_And_MobileInSendSmsRequestIsZerolException()
        {
            // Act-Assert
            var result = SendSmsValidation.Validate(ref SsoTestDataSet.SsoUserGuidIsNullAndMobileIsZeroInSendSmsRequest, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new SsoUserGuidInSendSmsRequestIsNullException(), new MobileInSendSmsRequestIsZerolException() };

            Assert.Equal(2, result.Count);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
            Assert.Equal(errors[1].Message, result[1].Message);
            Assert.Equal(errors[1].Code, result[1].Code);
        }

        /// <summary>
        /// If SsoUserGuid was null and mobile was invalid lenght, SsoUserGuidInSendSmsRequestIsNullException, MobileInSendSmsRequestIsInvalidException must be thrown.
        /// </summary>
        [Fact]
        public void SendSmsValidation_When_SsoUserGuid_Is_Null_And_Mobile_Is_Invalid_Lenght_Throw_SsoUserGuidInSendSmsRequestIsNullException_And_MobileInSendSmsRequestIsInvalidException()
        {
            // Act-Assert
            var result = SendSmsValidation.Validate(ref SsoTestDataSet.SsoUserGuidIsNullAndMobileIsInvalidLenghtInSendSmsRequest, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new SsoUserGuidInSendSmsRequestIsNullException(), new MobileInSendSmsRequestIsInvalidException() };

            Assert.Equal(2, result.Count);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
            Assert.Equal(errors[1].Message, result[1].Message);
            Assert.Equal(errors[1].Code, result[1].Code);
        }

        /// <summary>
        /// If SendSmsRequest was Ok, Exception count is 0.
        /// </summary>
        [Fact]
        public void SendSmsValidation_When_VerifyEmailRequest_Is_Ok_Exception_Count_Is_0()
        {
            // Act-Assert
            var result = SendSmsValidation.Validate(ref SsoTestDataSet.SendSmsRequestIsOk, ref SignUpFormErrors);

            Assert.Empty(result);
        }
    }
}
