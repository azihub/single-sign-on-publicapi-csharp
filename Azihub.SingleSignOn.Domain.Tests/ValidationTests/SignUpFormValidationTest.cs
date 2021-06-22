using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.Domain.DemoData;
using Azihub.SingleSignOn.Domain.Validations.SignUp;
using Azihub.SingleSignOn.Domain.Validations.SignUp.Exceptions;
using Xunit;

namespace Azihub.SingleSignOn.Domain.Tests.ValidationTests
{
    public class SignUpFormValidationTest : ValidationBaseTest
    {
        #region Check SignUpFormRequest model

        /// <summary>
        /// If SignUpFormRequest model is null, the method must throw SignUpFormIsNullException.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void SignUp_When_SignUpFormRequest_Is_Null_Throw_SignUpFormIsNullException()
        {
            // Act-Assert
            Assert.Throws<SignUpFormIsNullException>((() => SignUpFormValidation.Validate(ref SsoTestDataSet.SignUpFormNull, ref SignUpFormErrors)));
        }

        /// <summary>
        /// If SignUpFormRequest model is empty, the method must throw SignUpFormException.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void SignUp_When_SignUpFormRequest_Is_Empty_Throw_SignUpFormException()
        {
            // Act-Assert
            var result = SignUpFormValidation.Validate(ref SsoTestDataSet.SignUpFormEmpty, ref SignUpFormErrors);

            Assert.Equal(6, result.Count);
        }

        #endregion

        #region Check FirstName

        /// <summary>
        /// If the firstname in the signup form is empty, the method must throw FirstNameIsNullException.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void SignUp_When_FirstName_Is_Null_Throw_FirstNameIsNullException()
        {
            // Act-Assert
            var result = SignUpFormValidation.Validate(ref SsoTestDataSet.SignUpFormWithEmptyFirstName, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new FirstNameIsNullException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If the firstname characters in the signup form is less than minimum size, the method must throw FirstNameIsShortException.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void SignUp_When_FirstName_Characters_Is_Less_Than_Minimum_Throw_FirstNameIsShortException()
        {
            // Act-Assert
            var result = SignUpFormValidation.Validate(ref SsoTestDataSet.SignUpFormFirstNameCharactersIsSmall, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new FirstNameIsShortException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If the firstname characters in the signup form is more than maximum size, the method must throw FirstNameIsLongException.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void SignUp_When_FirstName_Characters_Is_More_Than_Maximum_Throw_FirstNameIsLongException()
        {
            // Act-Assert
            var result = SignUpFormValidation.Validate(ref SsoTestDataSet.SignUpFormFirstNameCharactersIsLarge, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new FirstNameIsLongException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        #endregion

        #region Check LastName

        /// <summary>
        /// If the lastname in the signup form is empty, the method must throw LastNameIsNullException.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void SignUp_When_LastName_Is_Empty_Throw_LastNameIsNullException()
        {
            // Act-Assert
            var result = SignUpFormValidation.Validate(ref SsoTestDataSet.SignUpFormWithEmptyLastName, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new LastNameIsNullException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If the lastname characters in the signup form is less than minimum size, the method must throw ShortLastNameSelectException.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void SignUp_When_LastName_Characters_Is_Less_Than_Minimum_Throw_ShortLastNameSelectException()
        {
            // Act-Assert
            var result = SignUpFormValidation.Validate(ref SsoTestDataSet.SignUpFormLastNameCharactersIsSmall, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new LastNameIsShortException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If the lastname characters in the signup form is more than maximum size, the method must throw LongLastNameSelectException.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void SignUp_When_LastName_Characters_Is_More_Than_Maximum_Throw_LongLastNameSelectException()
        {
            // Act-Assert
            var result = SignUpFormValidation.Validate(ref SsoTestDataSet.SignUpFormLastNameCharactersIsLarge, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new LastNameIsLongException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        #endregion

        #region Check Password

        /// <summary>
        /// If the password in the signup form is empty, the method must throw PasswordIsNullException.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void SignUp_When_Password_Is_Empty_Throw_PasswordIsNullException()
        {
            // Act-Assert
            var result = SignUpFormValidation.Validate(ref SsoTestDataSet.SignUpFormWithEmptyPassword, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new PasswordIsNullException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If the password in the signup form is bad, the method must throw PasswordExceptions.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void SignUp_When_Password_Is_Bad_Throw_PasswordExceptions()
        {
            // Act-Assert
            var result = SignUpFormValidation.Validate(ref SsoTestDataSet.SignUpFormWithBadPassword, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new PasswordExceptions() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        #endregion

        #region Check Email

        /// <summary>
        /// If the email in the signup form is empty, the method must throw EmailIsNullException.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void SignUp_When_Email_Is_Empty_Throw_EmailIsNullException()
        {
            // Act-Assert
            var result = SignUpFormValidation.Validate(ref SsoTestDataSet.SignUpFormWithEmptyEmail, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new EmailIsNullException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If the email in the signup form is bad, the method must throw EmailIsInvalidException.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void SignUp_When_Email_Is_Invalid_Throw_EmailIsInvalidException()
        {
            // Act-Assert
            var result = SignUpFormValidation.Validate(ref SsoTestDataSet.SignUpFormWithInvalidEmail, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new EmailIsInvalidException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        #endregion

        #region Check Mobile

        /// <summary>
        /// If the mobile in the signup form is empty, the method must throw MobileIsNullException.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void SignUp_When_Mobile_Is_Empty_Throw_MobileIsNullException()
        {
            // Act-Assert
            var result = SignUpFormValidation.Validate(ref SsoTestDataSet.SignUpFormWithEmptyMobile, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new MobileIsNullException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        /// <summary>
        /// If the mobile in the signup form is bad, the method must throw MobileIsInvalidException.
        /// </summary>
        /// <returns></returns>
        [Fact]
        public void SignUp_When_Mobile_Is_Invalid_Throw_MobileIsInvalidException()
        {
            // Act-Assert
            var result = SignUpFormValidation.Validate(ref SsoTestDataSet.SignUpFormWithInvalidMobile, ref SignUpFormErrors);

            BusinessLogicException[] errors = new BusinessLogicException[] { new MobileIsInvalidException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        #endregion

        #region Check GdCountryIso2Code

        /// <summary>
        /// If the _GdCountryIso2Code in the signup form is null, the method must throw GdCountryIso2CodeIsNullException.
        /// </summary>
        [Fact]
        public void SignUp_When_GdCountryIso2Code_Is_Empty_Throw_GdCountryIso2CodeIsNullException()
        {
            // Act-Assert
            var result = SignUpFormValidation.Validate(ref SsoTestDataSet.SignUpFormWithNullGdCountryIso2Code, ref SignUpFormErrors);

            var errors = new BusinessLogicException[] { new GdCountryIso2CodeIsNullException() };

            Assert.Single(result);
            Assert.Equal(errors[0].Message, result[0].Message);
            Assert.Equal(errors[0].Code, result[0].Code);
        }

        #endregion

    }
}
