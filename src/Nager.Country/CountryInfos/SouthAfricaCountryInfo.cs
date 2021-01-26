using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// South Africa
    /// </summary>
    public class SouthAfricaCountryInfo : ICountryInfo
    {
        public string CommonName => "South Africa";
        public string OfficialName => "Republic of South Africa";
        public Alpha2Code Alpha2Code => Alpha2Code.ZA;
        public Alpha3Code Alpha3Code => Alpha3Code.ZAF;
        public int NumericCode => 710;
        public string[] TLD => new [] { ".za" };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.SouthernAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BW,
            Alpha2Code.LS,
            Alpha2Code.MZ,
            Alpha2Code.NA,
            Alpha2Code.SZ,
            Alpha2Code.ZW,
        };

        public ICurrency[] Currencies => new [] { new ZarCurrency() };
        public string[] CallingCodes => new [] { "27" };
    }
}
