using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// United Kingdom
    /// </summary>
    public sealed class UnitedKingdomCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "United Kingdom";

        /// <inheritdoc/>
        public string OfficialName => "United Kingdom of Great Britain and Northern Ireland";

        /// <inheritdoc/>
        public string NativeName => "United Kingdom";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GB;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GBR;

        /// <inheritdoc/>
        public int NumericCode => 826;

        /// <inheritdoc/>
        public string[] TLD => [".uk"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.IE,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [GbpCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["44"];
    }
}
