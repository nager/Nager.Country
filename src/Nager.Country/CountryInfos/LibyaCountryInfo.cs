using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Libya
    /// </summary>
    public sealed class LibyaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Libya";

        /// <inheritdoc/>
        public string OfficialName => "State of Libya";

        /// <inheritdoc/>
        public string NativeName => "ليبيا";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.LY;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.LBY;

        /// <inheritdoc/>
        public int NumericCode => 434;

        /// <inheritdoc/>
        public string[] TLD => [".ly"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.DZ,
            Alpha2Code.TD,
            Alpha2Code.EG,
            Alpha2Code.NE,
            Alpha2Code.SD,
            Alpha2Code.TN,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [LydCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["218"];
    }
}
