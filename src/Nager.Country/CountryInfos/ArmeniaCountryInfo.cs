using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Armenia
    /// </summary>
    public sealed class ArmeniaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Armenia";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Armenia";

        /// <inheritdoc/>
        public string NativeName => "Հայաստան";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AM;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ARM;

        /// <inheritdoc/>
        public int NumericCode => 051;

        /// <inheritdoc/>
        public string[] TLD => [".am"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.AZ,
            Alpha2Code.GE,
            Alpha2Code.IR,
            Alpha2Code.TR,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new AmdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["374"];
    }
}
