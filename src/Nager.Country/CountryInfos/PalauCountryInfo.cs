using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Palau
    /// </summary>
    public class PalauCountryInfo : ICountryInfo
    {
        public string CommonName => "Palau";
        public string OfficialName => "Republic of Palau";
        public Alpha2Code Alpha2Code => Alpha2Code.PW;
        public Alpha3Code Alpha3Code => Alpha3Code.PLW;
        public int NumericCode => 585;
        public string[] TLD => new [] { ".pw" };

        public Region Region => Region.Oceania;
        public SubRegion SubRegion => SubRegion.Micronesia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new UsdCurrency() };
        public string[] CallingCodes => new [] { "680" };
    }
}
