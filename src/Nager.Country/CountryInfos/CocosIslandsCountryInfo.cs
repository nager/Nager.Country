using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Cocos (Keeling) Islands
    /// </summary>
    public class CocosIslandsCountryInfo : ICountryInfo
    {
        public string CommonName => "Cocos (Keeling) Islands";
        public string OfficialName => "Territory of the Cocos (Keeling) Islands";
        public Alpha2Code Alpha2Code => Alpha2Code.CC;
        public Alpha3Code Alpha3Code => Alpha3Code.CCK;
        public int NumericCode => 166;
        public string[] TLD => new [] { ".cc" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.AustraliaAndNewZealand;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new AudCurrency() };
        public string[] CallingCodes => new [] { "61" };
    }
}
