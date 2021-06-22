namespace Azihub.SingleSignOn.Domain
{
    public enum ErrorCodes
    {
        #region BusinessLogic

        #region SignUpForm
        SignUpForm = 100,

        FirstNameIsNull = 10011,
        FirstNameIsShort = 10012,
        FirstNameIsLong = 10013,

        LastNameIsNull = 10021,
        LastNameIsShort = 10022,
        LastNameIsLong = 10023,

        PasswordIsNotStrong = 10031,
        PasswordIsNull = 10032,

        EmailIsNull = 10041,
        EmailIsInvalid = 10042,
        EmailIsAlreadyRegister = 10043,

        MobileIsNull = 10051,
        MobileIsInvalid = 10052,
        MobileNumberIsAlreadyRegister = 10053,

        GdCountryIso2CodeIsNull = 10061,
        #endregion

        #region EditEmailForm
        EditEmailForm = 200,

        EmailInEditEmailFormIsNull = 20002,
        EmailInEditEmailFormIsInvalid = 20003,
        SsoUserGuidInEmailFormIsNull = 20004,
        #endregion

        #region VerifyEmail
        VerifyEmail = 300,
        SsoUserGuidInVerifyEmailRequestIsNull = 30002,
        SsoUserGuidInVerifyEmailRequestIsInvalid = 30003,
        EmailOtpIsNull = 30004,
        EmailOtpLenghtIsInvalid = 30005,
        InvalidEmailOtp = 30006,
        #endregion

        #region SendSms
        SendSms = 400,
        SsoUserGuidInSendSmsRequestIsNull = 40002,
        SsoUserGuidInSmsRequestIsInvalid = 40003,
        MobileInSendSmsRequestIsNull = 40004,
        MobileInSendSmsRequestIsZero = 40005,
        MobileInSendSmsRequestIsInvalid = 40006,
        #endregion

        #region VerifyOtp
        VerifyMobileOtp = 500,

        SsoUserGuidInVerifyMobileOtpRequestIsNull = 50002,
        SsoUserGuidInVerifyMobileOtpRequestIsInvalid = 50003,
        MobileOtpIsNull = 50004,
        MobileOtpLenghtIsInvalid = 50005,
        InvalidMobileOtp = 50006,
        #endregion

        #endregion

        #region Security
        SignUpFormFailed = 60001,
        SignUpFormIsNull = 60002,

        VerifyEmailFailed = 60003,
        EditEmailFormIsNull = 60004,
        EditEmailFormIsFailed = 60005,
        EmailBodyIsNull = 60006,
        EmailFormIsNull = 60007,
        VerifyEmailRequestIsNull = 60008,

        SendSmsRequestIsNull = 60009,
        SendSmsRequestFailed = 60010,
        VerifyMobileOtpRequestIsNull = 60011,
        VerifyMobileOtpFailed = 60012,
        InvalidMobileNumber = 60013,

        InstanceIsNull = 60014,
        PropertyNameIsNull = 60015,
        PropertyHasNotAttribute = 60016,
        InvalidEnum164NumberFormat = 60017,

        ShareParemetersRequestIsNull = 60018,
        UserAgentIsNull = 60019,
        UserIPAddressIsNull = 60020,
        UserIPAddressIsInvalid = 60021,
        #endregion

        #region ApplicationFailure

        DatabaseIsFailure = 70001,
        DbContextIsFailure = 70002,

        #endregion


        //#region ShareParameters
        //ShareParameters = 900,
        //ShareParemetersRequestIsNull = 90001,
        //UserAgentIsNull = 90002,
        //IPAddressIsNull = 90003,
        //UserIPAddressIsInvalid = 90004
        //#endregion

    }
}
