using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// South Africa
    /// </summary>
    public class SouthAfricaCountryInfo : ICountryInfo
    {
        ///<inheritdoc/>
        public string CommonName => "South Africa";
        ///<inheritdoc/>
        public string OfficialName => "Republic of South Africa";
        ///<inheritdoc/>
        public string NativeName => "South Africa";
        ///<inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.ZA;
        ///<inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ZAF;
        ///<inheritdoc/>
        public int NumericCode => 710;
        ///<inheritdoc/>
        public string[] TLD => new [] { ".za" };

        ///<inheritdoc/>
        public Region Region => Region.Africa;
        ///<inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAfrica;

        ///<inheritdoc/>
        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.BW,
            Alpha2Code.LS,
            Alpha2Code.MZ,
            Alpha2Code.NA,
            Alpha2Code.SZ,
            Alpha2Code.ZW,
        };

        ///<inheritdoc/>
        public ICurrency[] Currencies => new [] { new ZarCurrency() };
        ///<inheritdoc/>
        public string[] CallingCodes => new [] { "27" };
    }
}
