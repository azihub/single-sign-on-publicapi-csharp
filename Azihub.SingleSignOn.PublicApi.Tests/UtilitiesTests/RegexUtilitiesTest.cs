using Azihub.SingleSignOn.PublicApi.DemoData;
using Azihub.SingleSignOn.PublicApi.Utilities;
using Xunit;

namespace Azihub.SingleSignOn.PublicApi.Tests.UtilitiesTests
{
    public class RegexUtilitiesTest
    {
        #region IsValidPassword

        /// <summary>
        /// In the IsValidPassword method, if the password is empty, it must be returned false. 
        /// </summary>
        [Fact]
        public void IsValidPassword_When_Password_Is_Empty_Return_False()
        {
            // Arrange
            string password = SsoTestDataSet.EMPTY_PASSWORD;

            // Act 
            var result = RegexUtilities.IsValidPassword(ref password);

            // Assert
            Assert.False(result);
        }

        /// <summary>
        /// In the IsValidPassword method, if the password is null, it must be returned false. 
        /// </summary>
        [Fact]
        public void IsValidPassword_When_Password_Is_Null_Return_False()
        {
            // Arrenge
            var password = SsoTestDataSet.NULL_PASSWORD;

            // Act 
            var result = RegexUtilities.IsValidPassword(ref password);

            // Assert
            Assert.False(result);
        }

        /// <summary>
        /// In the IsValidPassword method, if the password is invalid, it must be returned false. 
        /// </summary>
        [Fact]
        public void IsValidPassword_When_Password_Is_Invalid_Return_False()
        {
            // Arrange
            string password = SsoTestDataSet.BAD_PASSWORD;

            // Act 
            var result = RegexUtilities.IsValidPassword(ref password);

            // Assert
            Assert.False(result);
        }

        /// <summary>
        /// In the IsValidPassword method, if the password is valid, it must be returned true. 
        /// </summary>
        [Fact]
        public void IsValidPassword_When_Password_Is_Valid_Return_True()
        {
            // Arrange
            string password = SsoTestDataSet.GOOD_PASSWORD;

            // Act 
            var result = RegexUtilities.IsValidPassword(ref password);

            //Assert
            Assert.True(result);
        }

        #endregion

        #region IsValidEmail

        /// <summary>
        /// In the IsValidEmail method, if the email is empty, it must be returned false. 
        /// </summary>
        [Fact]
        public void IsValidEmail_When_Email_Is_Empty_Return_False()
        {
            // Arrange
            string email = SsoTestDataSet.EMPTY_EMAIL;

            // Act 
            var result = RegexUtilities.IsValidEmail(ref email);

            // Assert
            Assert.False(result);
        }

        /// <summary>
        /// In the IsValidEmail method, if the email is null, it must be returned false. 
        /// </summary>
        [Fact]
        public void IsValidEmail_When_Email_Is_Null_Return_False()
        {
            // Arrange
            string password = SsoTestDataSet.NULL_PASSWORD;

            // Act 
            var result = RegexUtilities.IsValidEmail(ref password);

            // Assert
            Assert.False(result);
        }

        /// <summary>
        /// In the IsValidEmail method, if the password is invalid, it must be returned false. 
        /// </summary>
        [Fact]
        public void IsValidEmail_When_Email_Is_Invalid_Return_False()
        {
            // Arrange
            string email = SsoTestDataSet.INVALID_EMAIL;

            // Act 
            var result = RegexUtilities.IsValidEmail(ref email);

            // Assert
            Assert.False(result);
        }

        /// <summary>
        /// In the IsValidEmail method, if the email is valid, it must be returned true. 
        /// </summary>
        [Fact]
        public void IsValidEmail_When_Email_Is_Valid_Return_True()
        {
            // Arrange
            string email = SsoTestDataSet.VALID_EMAIL;

            // Act 
            var result = RegexUtilities.IsValidEmail(ref email);

            // Assert
            Assert.True( result);
        }

        #endregion
    }
}
