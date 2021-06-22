using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.DemoData;
using Azihub.SingleSignOn.Domain.Utilities;
using Azihub.SingleSignOn.Domain.Validations.SignUp.Exceptions;
using System;
using Xunit;

namespace Azihub.SingleSignOn.Domain.Tests.UtilitiesTests
{
    public class GenerateUtilitiesTest
    {
        #region GenerateHashPassword

        /// <summary>
        /// A passwordIsNullException must be thrown when the password is Null.
        /// </summary>
        [Fact]
        public void GenerateHashPassword_When_Password_Is_Null_Throw_PasswordIsNullException()
        {
            //Arrange
            string nullPassword = SsoTestDataSet.NULL_PASSWORD;

            //Act
            PasswordIsNullException result = Assert.Throws<PasswordIsNullException>((() =>
            (GenerateUtilities.GenerateHashPassword(ref nullPassword))));

            var errors = new BusinessLogicException[] { new PasswordIsNullException() };

            //Assert
            Assert.Equal(errors[0].Message, result.Message);
            Assert.Equal(errors[0].Code, result.Code);
        }

        /// <summary>
        /// A passwordIsNullException must be thrown when the password is Empty.
        /// </summary>
        [Fact]
        public void GenerateHashPassword_When_Password_Is_Empty_Throw_PasswordIsNullException()
        {
            //Arrange
            string emptyPassword = SsoTestDataSet.EMPTY_PASSWORD;

            //Act
            PasswordIsNullException result = Assert.Throws<PasswordIsNullException>((() =>
           (GenerateUtilities.GenerateHashPassword(ref emptyPassword))));

            var errors = new BusinessLogicException[] { new PasswordIsNullException() };

            //Assert
            Assert.Equal(errors[0].Message, result.Message);
            Assert.Equal(errors[0].Code, result.Code);
        }

        /// <summary>
        /// When the password is correct, the password must be returned.
        /// </summary>
        [Fact]
        public void GenerateHashPassword_When_Password_Is_OK_Return_Hash_Password()
        {
            //Arrange
            var password = SsoTestDataSet.GOOD_PASSWORD;

            //Act
            var result = GenerateUtilities.GenerateHashPassword(ref password);
            var expected = SsoTestDataSet.HASH_PASSWORD;

            //Assert
            Assert.Equal(result, expected);
        }

        #endregion

        #region GenerateVerifyEmailToken

        /// <summary>
        /// If we are in test mode, VerifyEmailToken method should return a expected verify email token.
        /// </summary>
        [Fact]
        public void VerifyEmailToken_When_Is_Test_Mode_Return_Expected_Token()
        {
            //Act
            var result = GenerateUtilities.GenerateVerifyEmailToken();

            var expected = Guid.Parse(SsoDemoData.SSO_EMAIL_TOKEN_JOHN_DOE_EMAIL_TOKEN);

            //Assert
            Assert.Equal(result, expected);
        }

        #endregion

        #region GenerateSsoUserGuid

        /// <summary>
        /// If we are in test mode, GenerateSsoUserGuid method should return a expected SsoUserGuid.
        /// </summary>
        [Fact]
        public void GenerateSsoUserGuid_When_Is_Test_Mode_Return_Expected_SsoUserGuid()
        {
            //Act
            var result = GenerateUtilities.GenerateSsoUserGuid();

            var expected = Guid.Parse(SsoDemoData.SSO_USER_JOHN_DOE_GUID);

            //Assert
            Assert.Equal(result, expected);
        }

        #endregion

        #region GenerateOtp

        /// <summary>
        /// If we are in test mode, GenerateOtp method should return a expected Otp.
        /// </summary>
        [Fact]
        public void GenerateOtp_When_Is_Test_Mode_Return_Expected_Otp()
        {
            //Act
            var result = GenerateUtilities.GenerateOtp();

            var expected = SsoTestDataSet.SSOOTP_TEST;

            //Assert
            Assert.Equal(result, expected);
        }

        #endregion
    }
}
