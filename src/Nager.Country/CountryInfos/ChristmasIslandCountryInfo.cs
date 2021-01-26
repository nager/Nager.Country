using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Christmas Island
    /// </summary>
    public class ChristmasIslandCountryInfo : ICountryInfo
    {
        public string CommonName => "Christmas Island";
        public string OfficialName => "Territory of Christmas Island";
        public Alpha2Code Alpha2Code => Alpha2Code.CX;
        public Alpha3Code Alpha3Code => Alpha3Code.CXR;
        public int NumericCode => 162;
        public string[] TLD => new [] { ".cx" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.AustraliaAndNewZealand;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new AudCurrency() };
        public string[] CallingCodes => new [] { "61" };
    }
}
