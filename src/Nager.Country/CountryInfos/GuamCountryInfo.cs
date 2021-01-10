using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guam
    /// </summary>
    public class GuamCountryInfo : ICountryInfo
    {
        public string CommonName => "Guam";
        public string OfficialName => "Guam";
        public Alpha2Code Alpha2Code => Alpha2Code.GU;
        public Alpha3Code Alpha3Code => Alpha3Code.GUM;
        public int NumericCode => 316;
        public string[] TLD => new [] { ".gu" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Micronesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "1671" };
    }
}
