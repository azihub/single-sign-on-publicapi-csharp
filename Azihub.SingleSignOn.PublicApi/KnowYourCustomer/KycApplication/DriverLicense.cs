using GdCountryIso2Code = Azihub.GlobalData.Base.Country.CountryIso2Code;
using System;

namespace Azihub.SingleSignOn.PublicApi.KnowYourCustomer.KycApplication
{
    public class DriverLicense : VerifiableDocument
    {
        public DriverLicense(GdCountryIso2Code issuedByCountry)
        {
            IssuedByCountry = issuedByCountry;
        }

        public GdCountryIso2Code IssuedByCountry { get; }
        public DateTime ExpiryDate { get; set; }
        public Image Front { get; set; }
        public Image Back { get; set; }
    }
}