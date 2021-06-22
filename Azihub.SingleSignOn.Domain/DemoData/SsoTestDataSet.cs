using GdCountryIso2Code = Azihub.GlobalData.Base.Country.CountryIso2Code;
using Azihub.SingleSignOn.Domain.Dtos;
using Azihub.SingleSignOn.Domain.Validations.EditEmail;
using Azihub.SingleSignOn.Domain.Validations.SendSms;
using Azihub.SingleSignOn.Domain.Validations.ShareParemetersInRequests;
using Azihub.SingleSignOn.Domain.Validations.SignUp;
using Azihub.SingleSignOn.Domain.Validations.VerifyEmail;
using Azihub.SingleSignOn.Domain.Validations.VerifyMobileOtp;
using System;

namespace Azihub.SingleSignOn.Domain.DemoData
{
    public static class SsoTestDataSet
    {
        #region SignUpFormRequest

        #region SignUpForm_Request

        #region SignUpForm_Null
        public static SignUpFormRequest SignUpFormNull = null;
        #endregion

        #region SignUpForm_Empty
        public static SignUpFormRequest SignUpFormEmpty = new SignUpFormRequest
        (
            EMPTY_FIRSTNAME,
            EMPTY_LASTNAME,
            EMPTY_EMAIL,
            EMPTY_PASSWORD,
            ZERO_MOBILE,
            NULL_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #region SignUpForm_Valid
        public static readonly SignUpFormRequest SignUpFormInit = new SignUpFormRequest
        (
            SsoDemoData.SSO_USER_JOHN_DOE_FIRSTNAME,
            SsoDemoData.SSO_USER_JOHN_DOE_LASTNAME,
            VALID_EMAIL,
            SsoDemoData.SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
            VALID_MOBILE,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #region SignUpForm_Security_Invalid
        public static SignUpFormRequest SignUpFormSecurityInvalid = new SignUpFormRequest
        (
            SsoDemoData.SSO_USER_JOHN_DOE_FIRSTNAME,
            SsoDemoData.SSO_USER_JOHN_DOE_LASTNAME,
            VALID_EMAIL,
            SsoDemoData.SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
            VALID_MOBILE,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            EMPTY_USERAGENT
        );
        #endregion

        #endregion

        #region SignUpForm_FirstName

        #region FirstName
        public const string EMPTY_FIRSTNAME = "";
        public const string SMALL_FIRSTNAME = "A";
        public const string LARGE_FIRSTNAME = "LARGE_FIRSTNAMELARGE_FIRSTNAMELARGE_FIRSTNAMELARGE_FIRSTNAMELARGE_FIRSTNAMELARGE_FIRSTNAME";
        #endregion

        #region SignUpForm_With_Empty_FirstName
        public static SignUpFormRequest SignUpFormWithEmptyFirstName = new SignUpFormRequest
        (
            EMPTY_FIRSTNAME,
            SsoDemoData.SSO_USER_JOHN_DOE_LASTNAME,
            VALID_EMAIL,
            SsoDemoData.SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
            VALID_MOBILE,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #region SignUpForm_FirstName_Characters_Is_Small
        public static SignUpFormRequest SignUpFormFirstNameCharactersIsSmall = new SignUpFormRequest
        (
            SMALL_FIRSTNAME,
            SsoDemoData.SSO_USER_JOHN_DOE_LASTNAME,
            VALID_EMAIL,
            SsoDemoData.SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
            VALID_MOBILE,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #region SignUpForm_FirstName_Characters_Is_Large
        public static SignUpFormRequest SignUpFormFirstNameCharactersIsLarge = new SignUpFormRequest
        (
            LARGE_FIRSTNAME,
            SsoDemoData.SSO_USER_JOHN_DOE_LASTNAME,
            VALID_EMAIL,
            SsoDemoData.SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
            VALID_MOBILE,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #endregion

        #region SignUpForm_LastName 

        #region LastName
        public const string EMPTY_LASTNAME = "";
        public const string SMALL_LASTNAME = "A";
        public const string LARGE_LASTNAME = "LARGE_LASTNAMELARGE_LASTNAMELARGE_LASTNAMELARGE_LASTNAMELARGE_LASTNAMELARGE_LASTNAMELARGE_LASTNAMELARGE_LASTNAME";
        #endregion

        #region SignUpForm_With_Empty_LastName
        public static SignUpFormRequest SignUpFormWithEmptyLastName = new SignUpFormRequest
        (
            SsoDemoData.SSO_USER_JOHN_DOE_FIRSTNAME,
            EMPTY_LASTNAME,
            VALID_EMAIL,
            SsoDemoData.SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
            VALID_MOBILE,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #region SignUpForm_LastName_Characters_Is_Small
        public static SignUpFormRequest SignUpFormLastNameCharactersIsSmall = new SignUpFormRequest
        (
            SsoDemoData.SSO_USER_JOHN_DOE_FIRSTNAME,
            SMALL_LASTNAME,
            VALID_EMAIL,
            SsoDemoData.SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
            VALID_MOBILE,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #region SignUpForm_LastName_Characters_Is_Large
        public static SignUpFormRequest SignUpFormLastNameCharactersIsLarge = new SignUpFormRequest
        (
            SsoDemoData.SSO_USER_JOHN_DOE_FIRSTNAME,
            LARGE_LASTNAME,
            VALID_EMAIL,
            SsoDemoData.SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
            VALID_MOBILE,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #endregion

        #region SignUpForm_Password

        #region Password
        public const string EMPTY_PASSWORD = "";
        public const string NULL_PASSWORD = null;
        public const string BAD_PASSWORD = "Abcd";
        public const string GOOD_PASSWORD = "P@ssw0rd";
        public const string HASH_PASSWORD = "b03ddf3ca2e714a6548e7495e2a03f5e824eaac9837cd7f159c67b90fb4b7342";
        #endregion


        #region SignUpForm_With_Empty_Password
        public static SignUpFormRequest SignUpFormWithEmptyPassword = new SignUpFormRequest
        (
            SsoDemoData.SSO_USER_JOHN_DOE_FIRSTNAME,
            SsoDemoData.SSO_USER_JOHN_DOE_LASTNAME,
            VALID_EMAIL,
            EMPTY_PASSWORD,
            VALID_MOBILE,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #region SignUpForm_With_Bad_Password
        public static SignUpFormRequest SignUpFormWithBadPassword = new SignUpFormRequest
        (
            SsoDemoData.SSO_USER_JOHN_DOE_FIRSTNAME,
            SsoDemoData.SSO_USER_JOHN_DOE_LASTNAME,
            VALID_EMAIL,
            BAD_PASSWORD,
            VALID_MOBILE,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #endregion

        #region SignUpForm_Email 

        #region Email
        public const string EMPTY_EMAIL = "";
        public const string INVALID_EMAIL = "Abcd.S.S";
        public const string VALID_EMAIL = "example@info.com";
        public const string DEFAULT_DUPLICATE_EMAIL = SsoDemoData.SSO_USER_JOHN_DOE_EMAIL;
        #endregion

        #region SignUpForm_With_Empty_Email
        public static SignUpFormRequest SignUpFormWithEmptyEmail = new SignUpFormRequest
        (
            SsoDemoData.SSO_USER_JOHN_DOE_FIRSTNAME,
            SsoDemoData.SSO_USER_JOHN_DOE_LASTNAME,
            EMPTY_EMAIL,
            SsoDemoData.SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
            VALID_MOBILE,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #region SignUpForm_With_Invalid_Email
        public static SignUpFormRequest SignUpFormWithInvalidEmail = new SignUpFormRequest
        (
            SsoDemoData.SSO_USER_JOHN_DOE_FIRSTNAME,
            SsoDemoData.SSO_USER_JOHN_DOE_LASTNAME,
            INVALID_EMAIL,
            SsoDemoData.SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
            VALID_MOBILE,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #region SignUpForm_With_duplicate_Email
        public static SignUpFormRequest SignUpFormWithduplicateEmail = new SignUpFormRequest
        (
            SsoDemoData.SSO_USER_JOHN_DOE_FIRSTNAME,
            SsoDemoData.SSO_USER_JOHN_DOE_LASTNAME,
            DEFAULT_DUPLICATE_EMAIL,
            SsoDemoData.SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
            VALID_MOBILE,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #endregion

        #region  SignUpForm_Mobile 

        #region Mobile
        public const string EMPTY_MOBILE = "";
        public const ulong ZERO_MOBILE = 0;
        public const ulong INVALID_MOBILE = 123456789;
        public const ulong VALID_MOBILE = 989393635342;
        public const ulong DEFAULT_DUPLICATE_MOBILE_NUMBER = SsoDemoData.SSO_USER_JOHN_DOE_MOBILE;
        #endregion

        #region SignUpForm_With_Empty_Mobile
        public static SignUpFormRequest SignUpFormWithEmptyMobile = new SignUpFormRequest
        (
            SsoDemoData.SSO_USER_JOHN_DOE_FIRSTNAME,
            SsoDemoData.SSO_USER_JOHN_DOE_LASTNAME,
            VALID_EMAIL,
            SsoDemoData.SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
            ZERO_MOBILE,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #region SignUpForm_With_Invalid_Mobile
        public static SignUpFormRequest SignUpFormWithInvalidMobile = new SignUpFormRequest
        (
            SsoDemoData.SSO_USER_JOHN_DOE_FIRSTNAME,
            SsoDemoData.SSO_USER_JOHN_DOE_LASTNAME,
            VALID_EMAIL,
            SsoDemoData.SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
            INVALID_MOBILE,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #region SignUpForm_With_duplicate_Mobile
        public static SignUpFormRequest SignUpFormWithduplicateMobile = new SignUpFormRequest
        (
            SsoDemoData.SSO_USER_JOHN_DOE_FIRSTNAME,
            SsoDemoData.SSO_USER_JOHN_DOE_LASTNAME,
            VALID_EMAIL,
            SsoDemoData.SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
            DEFAULT_DUPLICATE_MOBILE_NUMBER,
            DEFUALT_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );
        #endregion

        #endregion

        #region  SignUpForm_GdCountryIso2Code 

        #region SignUpForm_With_Null_GdCountryIso2Code
        public static SignUpFormRequest SignUpFormWithNullGdCountryIso2Code = new SignUpFormRequest
        (
            SsoDemoData.SSO_USER_JOHN_DOE_FIRSTNAME,
            SsoDemoData.SSO_USER_JOHN_DOE_LASTNAME,
            VALID_EMAIL,
            SsoDemoData.SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
            VALID_MOBILE,
            NULL_GDCOUNTRYCODE,
            DEFAULT_USER_IPADDRESS,
            DEFAULT_USERAGENT
        );

        #endregion
        #endregion

        #endregion

        #region ShareParemetersRequest

        public const string DEFAULT_USER_IPADDRESS = "127.0.0.1";
        public const string DEFAULT_USERAGENT = "chrome";
        public static GdCountryIso2Code DEFUALT_GDCOUNTRYCODE => GdCountryIso2Code.Abkhazia;
        public static GdCountryIso2Code NULL_GDCOUNTRYCODE = null;
        public const string EMPTY_USERAGENT = "";
        public const string EMPTY_USERIPADDRESS = "";
        public const string INVALID_USERIPADDRESS = "ABC";

        #region ShareParemetersRequest_Is_Null
        public static ShareParemetersRequest ShareParemetersRequestIsNull = null;
        #endregion

        #region ShareParemetersRequest_UserAgent_Is_Empty
        public static ShareParemetersRequest ShareParemetersRequestUserAgentIsEmpty = new ShareParemetersRequest(EMPTY_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region ShareParemetersRequest_UserIPAddress_Is_Empty
        public static ShareParemetersRequest ShareParemetersRequestUserIPAddressIsEmpty = new ShareParemetersRequest(DEFAULT_USERAGENT, EMPTY_USERIPADDRESS);
        #endregion

        #region ShareParemetersRequest_UserIPAddress_Is_Invalid
        public static ShareParemetersRequest ShareParemetersRequestUserIPAddressIsInvalid = new ShareParemetersRequest(DEFAULT_USERAGENT, INVALID_USERIPADDRESS);
        #endregion

        #region ShareParemetersRequest_UserAggent_And_IPAddress_Are_Empty
        public static ShareParemetersRequest ShareParemetersRequestUserAgentAndUserIPAddressEmpty = new ShareParemetersRequest(EMPTY_USERAGENT, EMPTY_USERIPADDRESS);
        #endregion

        #region ShareParemetersRequest_Is_Ok
        public static ShareParemetersRequest ShareParemetersRequestIsOk = new ShareParemetersRequest(DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #endregion

        #region EditEmailRequest

        #region EditEmailRequest_Null
        public static EditEmailRequest EditEmailRequestNull = null;
        #endregion

        #region EditEmailRequest_Empty
        public static EditEmailRequest EditEmailRequestEmpty = new EditEmailRequest(Guid.Empty, EMPTY_EMAIL, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region EditEmailRequest_SsoUserGuid_Is_Empty
        public static EditEmailRequest SsoUserGuidInEditEmailRequestIsEmpty = new EditEmailRequest(Guid.Empty, VALID_EMAIL, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region EditEmailRequest_Email_Is_Null
        public static EditEmailRequest EmailInEditEmailRequestIsNull = new EditEmailRequest(Guid.Parse(SsoDemoData.SSO_USER_JOHN_DOE_GUID), null, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region EditEmailRequest_Email_Is_Empty
        public static EditEmailRequest EmailInEditEmailRequestIsEmpty = new EditEmailRequest(Guid.Parse(SsoDemoData.SSO_USER_JOHN_DOE_GUID), EMPTY_EMAIL, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region EditEmailRequest_Email_Is_Invalid
        public static EditEmailRequest EmailInEditEmailRequestIsInvalid = new EditEmailRequest(Guid.Parse(SsoDemoData.SSO_USER_JOHN_DOE_GUID), INVALID_EMAIL, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region EditEmailRequest_Is_Ok
        public static EditEmailRequest EditEmailRequestIsOk = new EditEmailRequest(Guid.Parse(SsoDemoData.SSO_USER_JOHN_DOE_GUID), VALID_EMAIL, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #endregion

        #region EmailFormRequest

        public const string EMAIL_BODY = "123456";
        public const string EMPTY_EMAIL_BODY = "";

        #region EmailForm_Null
        public static EmailFormRequest EamilFormNull = null;
        #endregion

        #region EmailForm_Without_EmailAddress
        public static EmailFormRequest EamilFormWithEmptyEmailAddress = new EmailFormRequest(EMPTY_EMAIL, EMAIL_BODY);
        #endregion

        #region EmailForm_Without_Body
        public static EmailFormRequest EamilFormWithEmptyBody = new EmailFormRequest(VALID_EMAIL, EMPTY_EMAIL_BODY);
        #endregion

        #region EmailForm_TrueParameter
        public static EmailFormRequest EamilFormTrueParameter = new EmailFormRequest(VALID_EMAIL, EMAIL_BODY);
        #endregion

        #endregion

        #region VerifyEmailValidation

        public const string EMPTY_OTP = "";
        public const string INVALID_OTP = "Abcded";
        public const string INVALID_Lenght_OTP = "12345";
        public const string VALID_OTP = "123456";

        #region VerifyEmailRequest_Is_Null
        public static VerifyEmailRequest VerifyEmailRequestIsNull = null;
        #endregion

        #region VerifyEmailRequest_Is_Ok
        public static VerifyEmailRequest VerifyEmailRequestIsOk = new VerifyEmailRequest(Guid.Parse(SsoDemoData.SSO_EMAIL_TOKEN_JOHN_DOE_GUID), VALID_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region VerifyEmailRequest_When_No_Email_Found
        public static VerifyEmailRequest VerifyEmailRequestWhenNoEmailFound = new VerifyEmailRequest(Guid.NewGuid(), VALID_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region VerifyEmailRequest_When_No_SsoUser_Found
        public static VerifyEmailRequest VerifyEmailRequestWhenNoSsoUserFound = new VerifyEmailRequest(Guid.Parse(SsoDemoData.SSO_EMAIL_TOKEN_JOHN_DOE_GUID), VALID_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region VerifyEmailRequest_When_Everything_Is_Ok
        public static VerifyEmailRequest VerifyEmailRequestWhenEveryThingIsOk = new VerifyEmailRequest(Guid.Parse(SsoDemoData.SSO_USER_JOLI_DOE_GUID), VALID_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region SsoUserGuid_In_VerifyEmailRequest_Is_Null
        public static VerifyEmailRequest SsoUserGuidInVerifyEmailRequestIsNull = new VerifyEmailRequest(Guid.Empty, VALID_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region Otp_In_VerifyEmailRequest_Is_Empty
        public static VerifyEmailRequest OtpInVerifyEmailRequestIsEmpty = new VerifyEmailRequest(Guid.Parse(SsoDemoData.SSO_EMAIL_TOKEN_JOHN_DOE_GUID), EMPTY_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region Otp_Lenght_In_VerifyEmailRequest_Is_Invalid
        public static VerifyEmailRequest OtpLenghtInVerifyEmailRequestIsInvalid = new VerifyEmailRequest(Guid.Parse(SsoDemoData.SSO_EMAIL_TOKEN_JOHN_DOE_GUID), INVALID_Lenght_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region Otp_In_VerifyEmailRequest_Is_Invalid
        public static VerifyEmailRequest OtpInVerifyEmailRequestIsInvalid = new VerifyEmailRequest(Guid.Parse(SsoDemoData.SSO_EMAIL_TOKEN_JOHN_DOE_GUID), INVALID_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region SsoUserGuid_And_Otp_In_VerifyEmailRequest_Are_Null
        public static VerifyEmailRequest SsoUserGuidAndOtpInVerifyEmailRequestAreNull = new VerifyEmailRequest(Guid.Empty, EMPTY_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region SsoUserGuid_Is_Null_And_Otp_Is_InvalidLenght_In_VerifyEmailRequest
        public static VerifyEmailRequest SsoUserGuidIsNullAndOtpIsInvalidLenghtInVerifyEmailRequest = new VerifyEmailRequest(Guid.Empty, INVALID_Lenght_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region SsoUserGuid_Is_Null_And_Otp_Is_InvalidLenght_In_VerifyEmailRequest
        public static VerifyEmailRequest SsoUserGuidIsNullAndOtpIsInvalidInVerifyEmailRequest = new VerifyEmailRequest(Guid.Empty, INVALID_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #endregion

        #region VerifyMobileOtpValidation

        #region VerifyMobileOtpRequest_Is_Null
        public static VerifyMobileOtpRequest VerifyMobileOtpRequestIsNull = null;
        #endregion

        #region VerifyMobileOtpRequest_Is_Ok
        public static VerifyMobileOtpRequest VerifyMobileOtpRequestIsOk = new VerifyMobileOtpRequest(Guid.Parse(SsoDemoData.SSO_OTP_JOHN_DOE_GUID), VALID_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region VerifyMobileOtpRequest_When_No_Mobile_Found
        public static VerifyMobileOtpRequest VerifyMobileOtpRequestWhenNoMobileFound = new VerifyMobileOtpRequest(Guid.NewGuid(), VALID_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region VerifyMobileOtpRequest_When_No_SsoUser_Found
        public static VerifyMobileOtpRequest VerifyMobileOtpRequestWhenNoSsoUserFound = new VerifyMobileOtpRequest(Guid.Parse(SsoDemoData.SSO_EMAIL_TOKEN_JOHN_DOE_GUID), VALID_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region VerifyMobileOtpRequest_When_Everything_Is_Ok
        public static VerifyMobileOtpRequest VerifyMobileOtpRequestWhenEveryThingIsOk = new VerifyMobileOtpRequest(Guid.Parse(SsoDemoData.SSO_USER_JOLI_DOE_GUID), VALID_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region SsoUserGuid_In_VerifyMobileOtpRequest_Is_Null
        public static VerifyMobileOtpRequest SsoUserGuidInVerifyMobileOtpRequestIsNull = new VerifyMobileOtpRequest(Guid.Empty, VALID_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region Otp_In_VerifyMobileOtpRequest_Is_Empty
        public static VerifyMobileOtpRequest OtpInVerifyMobileOtpRequestIsEmpty = new VerifyMobileOtpRequest(Guid.Parse(SsoDemoData.SSO_OTP_JOHN_DOE_GUID), EMPTY_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region Otp_Lenght_In_VerifyMobileOtpRequest_Is_Invalid
        public static VerifyMobileOtpRequest OtpLenghtInVerifyMobileOtpRequestIsInvalid = new VerifyMobileOtpRequest(Guid.Parse(SsoDemoData.SSO_OTP_JOHN_DOE_GUID), INVALID_Lenght_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region Otp_In_VerifyMobileOtpRequest_Is_Invalid
        public static VerifyMobileOtpRequest OtpInVerifyMobileOtpRequestIsInvalid = new VerifyMobileOtpRequest(Guid.Parse(SsoDemoData.SSO_OTP_JOHN_DOE_GUID), INVALID_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region SsoUserGuid_And_Otp_In_VerifyMobileOtpRequest_Are_Null
        public static VerifyMobileOtpRequest SsoUserGuidAndOtpInVerifyMobileOtpRequestAreNull = new VerifyMobileOtpRequest(Guid.Empty, EMPTY_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region SsoUserGuid_Is_Null_And_Otp_Is_InvalidLenght_In_VerifyMobileOtpRequest
        public static VerifyMobileOtpRequest SsoUserGuidIsNullAndOtpIsInvalidLenghtInVerifyMobileOtpRequest = new VerifyMobileOtpRequest(Guid.Empty, INVALID_Lenght_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region SsoUserGuid_Is_Null_And_Otp_Is_InvalidLenght_In_VerifyMobileOtpRequest
        public static VerifyMobileOtpRequest SsoUserGuidIsNullAndOtpIsInvalidInVerifyMobileOtpRequest = new VerifyMobileOtpRequest(Guid.Empty, INVALID_OTP, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #endregion

        #region SendSms
        #region Otp

        public const string SSOOTP_TEST = "123456";

        #endregion

        #region SendSms_When_SendSmsRequest_Is_Null
        public static SendSmsRequest SendSmsWhenSendSmsRequestIsNull = null;
        #endregion

        #region SsoUserGuid_In_SendSms_Is_Null
        public static SendSmsRequest SsoUserGuidInSendSmsRequestIsNull = new SendSmsRequest(Guid.Empty, VALID_MOBILE.ToString(), DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region Mobile_In_SendSmsRequest_Is_Empty
        public static SendSmsRequest MobileInSendSmsRequestIsEmpty = new SendSmsRequest(Guid.Parse(SsoDemoData.SSO_USER_JOHN_DOE_GUID), EMPTY_MOBILE, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region Mobile_In_SendSmsRequest_Is_Zero
        public static SendSmsRequest MobileInSendSmsRequestIsZero = new SendSmsRequest(Guid.Parse(SsoDemoData.SSO_USER_JOHN_DOE_GUID), ZERO_MOBILE.ToString(), DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region Mobile_In_SendSmsRequest_Is_Invalid
        public static SendSmsRequest MobileInSendSmsRequestIsInvalid = new SendSmsRequest(Guid.Parse(SsoDemoData.SSO_EMAIL_TOKEN_JOHN_DOE_GUID), INVALID_MOBILE.ToString(), DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region SsoUserGuid_Is_Nul_And_Mobile_Is_Zero_In_SendSmsRequest
        public static SendSmsRequest SsoUserGuidIsNullAndMobileIsZeroInSendSmsRequest = new SendSmsRequest(Guid.Empty, ZERO_MOBILE.ToString(), DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region SsoUserGuid_And_Otp_In_SendSmsRequest_Are_Zero
        public static SendSmsRequest SsoUserGuidAndMobileAreNullInSendSmsRequest = new SendSmsRequest(Guid.Empty, EMPTY_MOBILE, DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region SsoUserGuid_Is_Null_And_Mobile_Is_InvalidLenght_In_SendSmsRequest
        public static SendSmsRequest SsoUserGuidIsNullAndMobileIsInvalidLenghtInSendSmsRequest = new SendSmsRequest(Guid.Empty, INVALID_MOBILE.ToString(), DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region SendSmsRequest_Is_Ok
        public static SendSmsRequest SendSmsRequestIsOk = new SendSmsRequest(Guid.Parse(SsoDemoData.SSO_EMAIL_TOKEN_JOHN_DOE_GUID), VALID_MOBILE.ToString(), DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region SendSmsRequest_When_No_SsoUser_Found
        public static SendSmsRequest SendSmsRequestWhenNoSsoUserFound = new SendSmsRequest(Guid.Parse(SsoDemoData.SSO_EMAIL_TOKEN_JOHN_DOE_GUID), VALID_MOBILE.ToString(), DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #region VerifyEmailRequest_When_Everything_Is_Ok
        public static SendSmsRequest SendSmsRequestWhenEveryThingIsOk = new SendSmsRequest(Guid.Parse(SsoDemoData.SSO_USER_JOLI_DOE_GUID), VALID_MOBILE.ToString(), DEFAULT_USERAGENT, DEFAULT_USER_IPADDRESS);
        #endregion

        #endregion
    }
}
