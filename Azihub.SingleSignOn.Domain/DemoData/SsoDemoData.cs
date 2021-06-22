using GdCountryIso2Code = Azihub.GlobalData.Base.Country.CountryIso2Code;
using Azihub.SingleSignOn.Domain.KnowYourCustomer;
using Azihub.SingleSignOn.Domain.KnowYourCustomer.KycApplication;
using Azihub.SingleSignOn.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Azihub.SingleSignOn.Domain.DemoData
{
    public static class SsoDemoData
    {
        public static SsoUser[] SsoUsers { get; }
        public static SsoEmailToken[] SsoEmailTokens { get; }
        public static SsoOtp[] SsoOtps { get; }
        public static Dictionary<string, SsoUser> SsoUsersDict { get; }

        #region KYC Data
        public static Dictionary<string, NationalId> NationalIdsDict { get; } = new Dictionary<string, NationalId>();
        public static Dictionary<string, DriverLicense> DriverLicensesDict { get; } = new Dictionary<string, DriverLicense>();
        public static Dictionary<string, Passport> PassportsDict { get; } = new Dictionary<string, Passport>();
        #endregion

        #region John Doe Data
        public const string SSO_USER_JOHN_DOE_GUID = "11A82BCC-9338-44B2-A9E9-8DC53817F1BB";
        public const string SSO_USER_JOLI_DOE_GUID = "11A82BCC-9338-44B2-A9E9-8DC53817F1CC";
        public const string SSO_USER_JOHN_DOE_FIRSTNAME = "Joe";
        public const string SSO_USER_JOHN_DOE_LASTNAME = "Doe";
        public const string SSO_USER_JOHN_DOE_EMAIL = "JOHN@DOE.COM";
        public const string SSO_USER_JOHN_DOE_PASSWORD_PLAIN = "11A82BcC-9338-44B2-A9E9-8DC53817F1BB";
        public const ulong SSO_USER_JOHN_DOE_MOBILE = 60123456789;
        public static readonly GdCountryIso2Code SSO_USER_JOHN_DOE_COUNTRY = GdCountryIso2Code.UnitedStates;
        public const string SSO_USER_JOHN_DOE_IPADDRESS = "10.10.10.10";
        public const string SSO_USER_JOHN_DOE_USERAGENT = "Mozilla/5.0 (platform; rv:geckoversion) Gecko/geckotrail Firefox/firefoxversion";

        public const string SSO_USER_JOHN_DOE_NATIONAL_ID_NO = "0032987137";
        public static readonly DateTime SSO_USER_JOHN_DOE_DATE_OF_BIRTH = new DateTime(1960, 3, 21);

        public const string SSO_EMAIL_TOKEN_JOHN_DOE_GUID = "31E20AF1-12DA-477B-9906-179BDCDB6F5F";
        public const string SSO_EMAIL_TOKEN_JOHN_DOE_EMAIL_TOKEN = "E53858B4-7D3D-4393-B76C-A988EC387199";
        public const string SSO_EMAIL_TOKEN_JOHN_DOE_EMAIL_TOKEN_OTP = "123456";
        public const string SSO_EMAIL_TOKEN_JOHN_DOE_IP_ADDRESS = "88.88.88.88";

        public const string SSO_OTP_JOHN_DOE_GUID = "D3F27263-CC57-4322-A307-968695A65B60";
        public const string SSO_OTP_JOHN_DOE_MESSAGE_ID = "02C6D6C1-7DB9-402B-AF6F-C2D757F387AA";
        public const string SSO_OTP_JOHN_DOE_TOKEN_OTP = "123456";

        #endregion

        #region Test Duplicate Data

        /// <summary>
        /// a random email that user make a typo and wishes to change it.
        /// </summary>
        public const string DEFAULT_EMAIL_TYPO = "TYPO@EMAIL.COM";

        /// <summary>
        /// Testing duplicate mobile number in SignUp form 
        /// hard-coding +60123456789 as duplicate number for testing.
        /// </summary>

        public const string NEW_MOBILE_REQUEST_OTP = "+12222553555";
        public const string NEW_MOBILE_REQUEST_OTP_VALUE = "654321";

        #endregion

        static SsoDemoData()
        {

            #region InitSsoUsers()

            SsoUsers = new SsoUser[]
            {
                new SsoUser
                {
                  FirstName=  SSO_USER_JOHN_DOE_FIRSTNAME,
                  LastName=    SSO_USER_JOHN_DOE_LASTNAME,
                  Email=   SSO_USER_JOHN_DOE_EMAIL,
                  Password=    SSO_USER_JOHN_DOE_PASSWORD_PLAIN,
                  Mobile=    SSO_USER_JOHN_DOE_MOBILE,
                  CountryResidenceIso2=   GdCountryIso2Code.UnitedStates.Code,
                  UserIpAddress=   IPAddress.Parse(SSO_USER_JOHN_DOE_IPADDRESS),
                  UserAgent=    SSO_USER_JOHN_DOE_USERAGENT
                }
            };

            SsoUsersDict = new Dictionary<string, SsoUser>();
            foreach (SsoUser appUser in SsoUsers)
            {
                SsoUsersDict.Add(appUser.Id.ToString().ToUpper(), appUser);
            }

            #endregion

            #region Kyc Data

            char DS = Path.DirectorySeparatorChar;

            NationalIdsDict.Add(
                    SSO_USER_JOHN_DOE_GUID,
                    new NationalId(
                        new Image(File.ReadAllBytes($"DemoData{DS}John.Doe.ID.Front.PNG"), Format.Png),
                        new Image(File.ReadAllBytes($"DemoData{DS}John.Doe.ID.Back.PNG"), Format.Png)
                     )
                  );

            #endregion
        }
    }
}
