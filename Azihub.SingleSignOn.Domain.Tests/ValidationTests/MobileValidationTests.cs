using Azihub.SingleSignOn.Domain.Validations.Mobile;
using Xunit;

namespace Azihub.SingleSignOn.Domain.Tests.ValidationTests
{
    public class MobileValidationTests
    {
        /// <summary>
        /// MobileValidation will be returned when the mobile phone is valid.
        /// </summary>
        [Fact]
        public void MobileValidation_When_Numbers_Are_Valid_ReturnsTrue()
        {
            // Arrange
            string[] validNumbers = {
                "60123919138",
                "16156382030",
                "989121234567",
            };

            // Act - Assert
            foreach (string number in validNumbers)
            {
                var mobile = number;

                var result = MobileValidation.IsValid(ref mobile);
                var expected = true;

                Assert.Equal(expected, result);
            }

        }

        /// <summary>
        ///  MobileValidation will be returned false when the mobile phone is landline.
        /// </summary>
        [Fact]
        public void MobileValidation_When_Numbers_Are_Landline_ReturnsFalse()
        {
            // Arrange
            string[] landlineNumbers =
            {
               "60327306464",
               "982182806677",
               "31203690399"
            };

            // Act - Assert
            foreach (string number in landlineNumbers)
            {
                var mobile = number;

                var result = MobileValidation.IsValid(ref mobile);
                var expected = false;

                Assert.Equal(expected, result);
            }
        }

        /// <summary>
        /// MobileValidation will be returned false when the mobile phone is not valid.
        /// </summary>
        [Fact]
        public void MobileValidation_When_Numbers_Are_Invalid_ReturnsFalse()
        {
            // Arrange
            string[] invalidNumbers =
            {
                "601239191",
                "161563820",
                "9891212347",
            };

            // Act - Assert
            foreach (string number in invalidNumbers)
            {
                var mobile = number;

                var result = MobileValidation.IsValid(ref mobile);
                var expected = false;

                Assert.Equal(expected, result);
            }
        }
    }

}
