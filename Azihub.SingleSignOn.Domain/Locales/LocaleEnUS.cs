using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Azihub.SingleSignOn.Domain.Locales
{
    /// <summary>
    /// Class container of English translation of localization.
    /// </summary>
    public static class LocaleEnUS
    {
        public const string BY_SIGN_UP_YOU_AGREE_TO_OUR = "با ثبت نام کردن شما قوانین و شرایط سایت را موافقت می کنید";
        public const string TERMS = "شرایط";
        public const string PRIVACY_POLICY = "قوانین حریم شخصی";

        #region Email
        public const string EDIT_EMAIL_FAILED = "ویرایش ایمیل موفق نبود";
        public const string EMAIL_OTP_IS_NULL = "کد تایید ایمیل نمیتواند خالی باشد";
        public const string EMAIL_OTP_LENGHT_IS_INVALID = "تعداد کاراکترهای کد تایید نادرست است";
        public const string EMAIL_OTP_IS_INVALID = "کد تایید نامعتبر است";
        //public const string VERIFY_EMAIL_REQUEST_IS_NULL = "VERIFY_EMAIL_REQUEST_IS_NULL";
        public const string EMAIL_IS_NULL = "آدرس ایمیل نمی تواند خالی باشد";
        public const string EMAIL_FORM_IS_NULL = "گیرنده ایمیل خالی است";
        public const string EMAIL_BODY_IS_NULL = "متن ایمیل خالی است";
        public const string EMAIL_SUBJECT_IS_NULL = "موضوع ایمیل خالی است";
        public const string EMAIL_IS_ALREADY_REGISTER = " این ایمیل قبلا ثبت شده است";
        #endregion

        #region SsoUserGuid
        public const string SSOUSERGUID_IS_INVALID = "شناسه کاربر نا معتبر است";
        public const string SSOUSERGUID_IS_NULL = "شناسه کاربر خالی است";
        #endregion

        #region Mobile
        //public const string INVALID_ENUM_164_NUMBER_FORMAT = "INVALID_ENUM_164_NUMBER_FORMAT";
        public const string MOBILE_NUMBER_IS_INVALID = "شماره موبایل نامعتبر است";
        public const string MOBILE_NUMBER_IS_NULL = "شماره موبایل خالی است";
        public const string MOBILE_NUMBER_IS_ZERO = "شماره موبال نمی تواند صفر باشد";
        public const string MOBILE_NUMBER_IS_ALREADY_REGISTER = "این شماره موبایل قبلا ثبت نام شده است";
        public const string MOBILE_OTP_IS_INVALID = "کد تایید شماره موبایل نامعتبر است";
        public const string MOBILE_OTP_IS_Null = "کد تایید موبایل خالی است";
        public const string MOBILE_OTP_LENGHT_IS_INVALID = "نعداد کاراکترهای کد تایید صحیح نیست";
        #endregion

        #region SendSms
        //public const string SEND_SMS_REQUEST_IS_NULL = "SEND_SMS_REQUEST_IS_NULL";
        #endregion

        #region share Parameter
        //public const string SHARE_PARAMETERS_REQUESTS_IS_NULL = "SHARE_PARAMETERS_REQUESTS_IS_NULL";
        public const string USER_AGENT_IS_NULL = "مشخصات سیستم عامل کابر خالی است ";
        public const string USER_IP_ADDRESS_IS_INVALID = "آدرس آی پی کاربر نامعتبر است";
        public const string USER_IP_ADDRESS_IS_NULL = "آدرس آی پی کاربر خالی است";
        #endregion

        #region FirstName
        public const string FIRST_NAME_IS_NULL = "نام خالی است";
        public const string FIRST_NAME_IS_SHORT = "نام کوتاه است";
        public const string FIRST_NAME_IS_LONG = "نام طولانی است";
        #endregion

        #region LastName
        public const string LAST_NAME_IS_NULL = "نام خانوادگی خالی است";
        public const string LAST_NAME_IS_SHORT = "نام خانوادگی کوتاه است";
        public const string LAST_NAME_IS_LONG = "نام خانوادگی طولانی است";
        #endregion

        #region GdContryCode
        public const string GDCOUNTRYISO2CODE_IS_NULL = "کد کشور خالی است";
        #endregion

        #region Password
        public const string PASSWORD_IS_NOT_STRONG = "پسورد ضعیف است";
        public const string PASSWORD_IS_NULL = "پسورد خالی است";
        #endregion

        #region SignupForm
        //public const string SIGNUP_FORM_IS_NULL = "SIGNUP_FORM_IS_NULL";
        #endregion

        /// <summary>
        /// This method get all LocaleConsts and LocaleEnUS class fields by reflections.
        /// It then checks that all LocaleConsts class fields are available in LocaleEnUS.
        /// If all the fields of the two classes are equal, we add and return the values of these fields in the LocaleEnUS class to a dictionary.
        /// A NullReferenceException is thrown even if a field does not exist in the LocaleEnUS class.
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> GetData()
        {
            // Get all field by reflection in LocaleConsts and LocaleEnUS
            var localizationField = typeof(LocaleConsts).GetFields(BindingFlags.Public | BindingFlags.Static);
            var localeEnUs = typeof(LocaleEnUS).GetFields(BindingFlags.Public | BindingFlags.Static);

            // Define a dictionary to add field names and values
            var data = new Dictionary<string, string>();
            foreach (var item in localizationField)
            {
                // Get field from LocaleEnUS
                var getLocaleEnUSField = typeof(LocaleEnUS).GetField(item.Name);

                // Check field in LocaleEnUS
                var checkLocaleEnUSField = localeEnUs.Any(x => x.Name == item.Name);
                if (checkLocaleEnUSField == false)
                    throw new NullReferenceException();

                // Add field to data Dictionary
                data.Add($"{item.Name}", $"{getLocaleEnUSField.GetValue(item.Name)}");
            }

            return data;
        }


    }
}
