using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// South Africa
    /// </summary>
    public sealed class SouthAfricaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "South Africa";

        /// <inheritdoc/>
        public string OfficialName => "Republic of South Africa";

        /// <inheritdoc/>
        public string NativeName => "South Africa";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.ZA;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ZAF;

        /// <inheritdoc/>
        public int NumericCode => 710;

        /// <inheritdoc/>
        public string[] TLD => [".za"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BW,
            Alpha2Code.LS,
            Alpha2Code.MZ,
            Alpha2Code.NA,
            Alpha2Code.SZ,
            Alpha2Code.ZW,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [ZarCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["27"];
    }
}
