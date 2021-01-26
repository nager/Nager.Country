using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// South Georgia
    /// </summary>
    public class SouthGeorgiaCountryInfo : ICountryInfo
    {
        public string CommonName => "South Georgia";
        public string OfficialName => "South Georgia and the South Sandwich Islands";
        public Alpha2Code Alpha2Code => Alpha2Code.GS;
        public Alpha3Code Alpha3Code => Alpha3Code.SGS;
        public int NumericCode => 239;
        public string[] TLD => new [] { ".gs" };

        public Region Region => Region.Antarctic;
        public SubRegion SubRegion => SubRegion.None;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new GbpCurrency() };
        public string[] CallingCodes => new [] { "500" };
    }
}
