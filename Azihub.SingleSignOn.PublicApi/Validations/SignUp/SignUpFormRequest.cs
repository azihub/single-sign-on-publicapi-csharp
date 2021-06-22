using GdCountryIso2Code = Azihub.GlobalData.Base.Country.CountryIso2Code;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Azihub.SingleSignOn.PublicApi.Validations.SignUp
{

    [DataContract]
    public class SignUpFormRequest
    {
        [Obsolete("Not allowed to use this for domain instantiation, must pass a Guid")]
        public SignUpFormRequest()
        {
            // #XXX Data validation on serverside is needed when BSON received from client
        }

        #region Server Side overload

        /// <summary>
        /// This overload can only be used at server-side where IP and Headers are available
        /// </summary>
        /// <param name = "firstname" />
        /// < param name="lastname" />
        /// <param name = "email" />
        /// < param name="password"></param>
        /// <param name = "mobile" />
        /// < param name="residentCountry"></param>
        /// <param name = "userIpAddress" />
        /// < param name="userAgent"></param>
        public SignUpFormRequest(string firstname,
                                 string lastname,
                                 string email,
                                 string password,
                                 ulong mobile,
                                 GdCountryIso2Code residentCountry,
                                 string userIpAddress,
                                 string userAgent)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Password = password;
            UserIpAddress = userIpAddress;
            UserAgent = userAgent;
            ResidentCountry = residentCountry;
            Mobile = mobile;

        }
        #endregion

        #region Client-side overload

        /// <summary>
        /// This overload can only be used at client-side(iOS, Android or Blazor)
        /// </summary>
        /// <param name = "firstname" ></ param >
        /// < param name="lastname"></param>
        /// <param name = "email" ></ param >
        /// < param name="password"></param>
        /// <param name = "mobile" ></ param >
        /// < param name="residentCountry"></param>
        public SignUpFormRequest(string firstname,
                                 string lastname,
                                 string email,
                                 string password,
                                 string mobile,
                                 GdCountryIso2Code residentCountry)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Password = password;
            ResidentCountry = residentCountry;
            Mobile = ulong.Parse(mobile);
        }
        #endregion

        [DataMember(Order = 1)]
        [MaxLength(55), MinLength(2)]
        public string FirstName { get; set; }

        [DataMember(Order = 2)]
        [MaxLength(50), MinLength(2)]
        public string LastName { get; set; }

        [DataMember(Order = 3)]
        [EmailAddress]
        public string Email { get; set; }

        [DataMember(Order = 4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataMember(Order = 5)]
        public ulong Mobile { get; set; }

        [DataMember(Order = 6)]
        public GdCountryIso2Code ResidentCountry { get; set; }

        [DataMember(Order = 7)]
        public string UserIpAddress { get; set; }

        [DataMember(Order = 8)]
        public string UserAgent { get; set; }

    }
}