using GdCountryIso2Code = Azihub.GlobalData.Base.Country.CountryIso2Code;
using System;

namespace Azihub.SingleSignOn.PublicApi.KnowYourCustomer.KycApplication
{
    public class KycApplication
    {

        #region Application by National ID

        /// <summary> 
        /// Application by <see cref="KycType.NationalId"/>
        /// </summary>
        /// <param name="firstName">First Name</param>
        /// <param name="lastName">Last Name</param>
        /// <param name="nationalIdNumber">National ID Number</param>
        /// <param name="dateOfBirth">Date of Birth</param>
        /// <param name="placeOfBirth">Place of Birth</param>
        /// <param name="countryOfResident">Country of Resident</param>
        /// <param name="nationalities"></param>
        /// <param name="countryOfBirth"></param>
        /// <param name="nationalId"></param>
        /// <param name="proofOfAddress"></param>
        /// <param name="selfieWithId"></param>
        public KycApplication(
            Guid ssoUserId,
            string firstName,
            string lastName,
            string nationalIdNumber,
            DateTime dateOfBirth,
            string placeOfBirth,
            GdCountryIso2Code countryOfResident,
            GdCountryIso2Code nationalityAtBirth,
            GdCountryIso2Code[] nationalities,
            GdCountryIso2Code countryOfBirth,
            NationalId nationalId,
            Image proofOfAddress,
            Image selfieWithId)
        {
            SsoUserId = ssoUserId;
            FirstName = firstName;
            LastName = lastName;
            NationalIdNumber = nationalIdNumber;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
            CountryOfResident = countryOfResident;
            NationalityAtBirth = nationalityAtBirth;
            Nationalities = nationalities;
            CountryOfBirth = countryOfBirth;
            NationalId = nationalId;
            ProofOfAddress = proofOfAddress;
            SelfieWithId = selfieWithId;
        }

        #endregion

        #region Application by Passport

        /// <summary>
        /// Application by Passport
        /// </summary>
        /// <param name="ssoUserId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="nationalIdNumber"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="placeOfBirth"></param>
        /// <param name="countryOfResident"></param>
        /// <param name="nationalities"></param>
        /// <param name="countryOfBirth"></param>
        /// <param name="passport"></param>
        /// <param name="proofOfAddress"></param>
        /// <param name="selfieWithId"></param>
        public KycApplication(
            Guid ssoUserId,
            string firstName,
            string lastName,
            string nationalIdNumber,
            DateTime dateOfBirth,
            string placeOfBirth,
            GdCountryIso2Code countryOfResident,
            GdCountryIso2Code nationalityAtBirth,
            GdCountryIso2Code[] nationalities,
            GdCountryIso2Code countryOfBirth,
            Passport passport,
            Image proofOfAddress,
            Image selfieWithId)
        {
            SsoUserId = ssoUserId;
            FirstName = firstName;
            LastName = lastName;
            NationalIdNumber = nationalIdNumber;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
            CountryOfResident = countryOfResident;
            NationalityAtBirth = nationalityAtBirth;
            Nationalities = nationalities;
            CountryOfBirth = countryOfBirth;
            Passport = passport;
            ProofOfAddress = proofOfAddress;
            SelfieWithId = selfieWithId;
            KycType = ApplicaitonTypeEnum.DriverLicense;
        }

        #endregion

        #region Application by Driver License

        /// <summary>
        /// Application by DriverLicense
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="nationalIdNumber"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="placeOfBirth"></param>
        /// <param name="countryOfResident"></param>
        /// <param name="nationalities"></param>
        /// <param name="countryOfBirth"></param>
        /// <param name="driverLicense"></param>
        /// <param name="proofOfAddress"></param>
        /// <param name="selfieWithId"></param>
        public KycApplication(
            Guid ssoUserId,
            string firstName,
            string lastName,
            string nationalIdNumber,
            DateTime dateOfBirth,
            string placeOfBirth,
            GdCountryIso2Code countryOfResident,
            GdCountryIso2Code nationalityAtBirth,
            GdCountryIso2Code[] nationalities,
            GdCountryIso2Code countryOfBirth,
            DriverLicense driverLicense,
            Image proofOfAddress,
            Image selfieWithId)
        {
            SsoUserId = ssoUserId;
            FirstName = firstName;
            LastName = lastName;
            NationalIdNumber = nationalIdNumber;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
            CountryOfResident = countryOfResident;
            Nationalities = nationalities;
            CountryOfBirth = countryOfBirth;
            DriverLicense = driverLicense;
            ProofOfAddress = proofOfAddress;
            SelfieWithId = selfieWithId;
            KycType = ApplicaitonTypeEnum.DriverLicense;
        }

        #endregion

        public Guid SsoUserId { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string NationalIdNumber { get; }
        public DateTime DateOfBirth { get; }

        /// <summary>
        /// City or Village name
        /// </summary>
        public string PlaceOfBirth { get; }
        public GdCountryIso2Code CountryOfResident { get; }
        public GdCountryIso2Code NationalityAtBirth { get; }

        public GdCountryIso2Code[] Nationalities { get; }
        public GdCountryIso2Code CountryOfBirth { get; }
        public NationalId NationalId { get; }
        public Passport Passport { get; }
        public DriverLicense DriverLicense { get; }
        public Image ProofOfAddress { get; }
        public Image SelfieWithId { get; }
        public KycStatus KycStatus { get; set; } = KycStatus.PendingApproval;
        public ApplicaitonTypeEnum KycType { get; }
    }

    public enum ApplicaitonTypeEnum
    {
        NationalId,
        Passport,
        DriverLicense
    }
}