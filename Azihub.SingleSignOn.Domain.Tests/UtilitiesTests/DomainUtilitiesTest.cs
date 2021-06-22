using Azihub.SingleSignOn.Domain.DemoData;
using Azihub.SingleSignOn.Domain.Utilities;
using Azihub.SingleSignOn.Domain.Utilities.Exceptions;
using Azihub.SingleSignOn.Domain.Validations.SignUp;
using Xunit;

namespace Azihub.SingleSignOn.Domain.Tests.UtilitiesTests
{
    public class DomainUtilitiesTest
    {

        #region GetMaxLength

        /// <summary>
        /// In the GetMaxLength method, if the instance is null, the InstanceIsNullException must be thrown. 
        /// </summary>
        [Fact]
        public void GetMaxLength_When_Instance_Is_Null_Throw_InstanceIsNullException()
        {
            // Act - Assert 
            Assert.Throws<InstanceiIsNullException>((() =>
            ((SignUpFormRequest)null).GetMaxLength("FirstName")));
        }

        /// <summary>
        /// In the GetMaxLength method, if the propertyname is null, the PropertyNameIsNullException must be thrown. 
        /// </summary>
        [Fact]
        public void GetMaxLength_When_PropertyName_Is_Null_Throw_PropertyNameIsNullException()
        {
            // Arrange
            SignUpFormRequest signUpFormRequest = SsoTestDataSet.SignUpFormInit;

            // Act - Assert
            Assert.Throws<PropertyNameIsNullException>((() =>
            signUpFormRequest.GetMaxLength("")));
        }

        /// <summary>
        /// In the GetMaxLength method, if the property has not MaxLength attribute, the PropertyHasNotAttributeException must be thrown. 
        /// </summary>
        [Fact]
        public void GetMaxLength_When_Attribute_Is_Null_Throw_PropertyHasNotAttributeException()
        {
            // Arrange
            SignUpFormRequest signUpFormRequest = SsoTestDataSet.SignUpFormInit;

            // Act - Assert
            Assert.Throws<PropertyHasNotAttributeException>((() =>
            signUpFormRequest.GetMaxLength("Email")));
        }

        #endregion

        #region GetMinLength

        /// <summary>
        /// In the GetMinLength method, if the instance is null, the InstanceiIsNullException must be thrown. 
        /// </summary>
        [Fact]
        public void GetMinLength_When_Instance_Is_Null_Throw_InstanceiIsNullException()
        {
            // Act - Assert
            Assert.Throws<InstanceiIsNullException>((() =>
            ((SignUpFormRequest)null).GetMinLength("FirstName")));
        }

        /// <summary>
        /// In the GetMinLength method, if the propertyname is null, the PropertyNameIsNullException must be thrown. 
        /// </summary>
        [Fact]
        public void GetMinLength_When_PropertyName_Is_Null_Throw_PropertyNameIsNullExceptionn()
        {
            // Arrange
            SignUpFormRequest signUpFormRequest = SsoTestDataSet.SignUpFormInit;

            // Act - Assert
            Assert.Throws<PropertyNameIsNullException>((() =>
            signUpFormRequest.GetMinLength("")));
        }

        /// <summary>
        ///  In the GetMinLength method, if the property has not MinLength attribute, the PropertyHasNotAttributeException must be thrown. 
        /// </summary>
        [Fact]
        public void GetMinLength_When_Attribute_Is_Null_Throw_PropertyHasNotAttributeException()
        {
            // Arrange
            SignUpFormRequest signUpFormRequest = SsoTestDataSet.SignUpFormInit;

            // Act - Assert
            Assert.Throws<PropertyHasNotAttributeException>((() =>
            signUpFormRequest.GetMinLength("Email")));
        }

        #endregion
    }
}
