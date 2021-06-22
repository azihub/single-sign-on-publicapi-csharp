using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.DemoData;
using Azihub.SingleSignOn.Domain.Validations.ShareParemetersInRequests;
using Azihub.SingleSignOn.Domain.Validations.ShareParemetersInRequests.Exceptions;
using Xunit;

namespace Azihub.SingleSignOn.Domain.Tests.ValidationTests
{
    public class ShareParemetersInRequestsValidationTests : ValidationBaseTest
    {
        /// <summary>
        /// If ShareParemetersRequest was null, ShareParemetersRequestIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void ShareParemetersInRequestsValidation_When_ShareParemetersRequest_Is_Null_Throw_ShareParemetersRequestIsNullException()
        {
            // Act-Assert
            Assert.Throws<ShareParemetersRequestIsNullException>((() => ShareParemetersInRequestsValidation.Validate(ref SsoTestDataSet.ShareParemetersRequestIsNull)));
        }

        /// <summary>
        /// If UserAgent was empty, UserAgentIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void ShareParemetersInRequestsValidation_When_UserAgent_Is_Empty_Throw_UserAgentIsNullException()
        {
            // Act-Assert
            Assert.Throws<UserAgentIsNullException>((() => ShareParemetersInRequestsValidation.Validate(ref SsoTestDataSet.ShareParemetersRequestUserAgentIsEmpty)));
        }

        /// <summary>
        /// If UserIPAddress was empty, UserIPAddressIsNullException must be thrown.
        /// </summary>
        [Fact]
        public void ShareParemetersInRequestsValidation_When_UserIPAddress_Is_Null_Throw_UserIPAddressIsNullException()
        {
            // Act-Assert
            Assert.Throws<UserIPAddressIsNullException>((() => ShareParemetersInRequestsValidation.Validate(ref SsoTestDataSet.ShareParemetersRequestUserIPAddressIsEmpty)));
        }

        /// <summary>
        /// If UserIPAddress was Invalid, UserIPAddressIsInvalidException must be thrown.
        /// </summary>
        [Fact]
        public void ShareParemetersInRequestsValidation_When_UserIPAddress_Is_Invalid_Throw_UserIPAddressIsInvalidException()
        {
            // Act-Assert
            Assert.Throws<UserIPAddressIsInvalidException>((() => ShareParemetersInRequestsValidation.Validate(ref SsoTestDataSet.ShareParemetersRequestUserIPAddressIsInvalid)));
        }
    }
}
