using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Philippines
    /// </summary>
    public class PhilippinesCountryInfo : ICountryInfo
    {
        public string CommonName => "Philippines";
        public string OfficialName => "Republic of the Philippines";
        public Alpha2Code Alpha2Code => Alpha2Code.PH;
        public Alpha3Code Alpha3Code => Alpha3Code.PHL;
        public int NumericCode => 608;
        public string[] TLD => new [] { ".ph" };

        public Region Region => Region.Asia;
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
        };

        public ICurrency[] Currencies => new [] { new PhpCurrency() };
        public string[] CallingCodes => new [] { "63" };
    }
}
