using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// South Georgia
    /// </summary>
    public sealed class SouthGeorgiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "South Georgia";

        /// <inheritdoc/>
        public string OfficialName => "South Georgia and the South Sandwich Islands";

        /// <inheritdoc/>
        public string NativeName => "South Georgia";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GS;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SGS;

        /// <inheritdoc/>
        public int NumericCode => 239;

        /// <inheritdoc/>
        public string[] TLD => [".gs"];

        /// <inheritdoc/>
        public Region Region => Region.Antarctic;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.None;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries => [];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new GbpCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["500"];
    }
}
