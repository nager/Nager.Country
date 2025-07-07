using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Oman
    /// </summary>
    public sealed class OmanCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Oman";

        /// <inheritdoc/>
        public string OfficialName => "Sultanate of Oman";

        /// <inheritdoc/>
        public string NativeName => "عمان";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.OM;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.OMN;

        /// <inheritdoc/>
        public int NumericCode => 512;

        /// <inheritdoc/>
        public string[] TLD => [".om"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.SA,
            Alpha2Code.AE,
            Alpha2Code.YE,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new OmrCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["968"];
    }
}
