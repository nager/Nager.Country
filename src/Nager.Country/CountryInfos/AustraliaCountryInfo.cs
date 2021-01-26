using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Australia
    /// </summary>
    public class AustraliaCountryInfo : ICountryInfo
    {
        public string CommonName => "Australia";
        public string OfficialName => "Commonwealth of Australia";
        public Alpha2Code Alpha2Code => Alpha2Code.AU;
        public Alpha3Code Alpha3Code => Alpha3Code.AUS;
        public int NumericCode => 036;
        public string[] TLD => new [] { ".au" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.AustraliaAndNewZealand;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new AudCurrency() };
        public string[] CallingCodes => new [] { "61" };
    }
}
