using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Timor-Leste
    /// </summary>
    public sealed class TimorLesteCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Timor-Leste";

        /// <inheritdoc/>
        public string OfficialName => "Democratic Republic of Timor-Leste";

        /// <inheritdoc/>
        public string NativeName => "Timor-Leste";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TL;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TLS;

        /// <inheritdoc/>
        public int NumericCode => 626;

        /// <inheritdoc/>
        public string[] TLD => [".tl"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.ID,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new UsdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["670"];
    }
}
