using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Romania
    /// </summary>
    public sealed class RomaniaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Romania";

        /// <inheritdoc/>
        public string OfficialName => "Romania";

        /// <inheritdoc/>
        public string NativeName => "România";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.RO;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.ROU;

        /// <inheritdoc/>
        public int NumericCode => 642;

        /// <inheritdoc/>
        public string[] TLD => [".ro"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SoutheastEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.BG,
            Alpha2Code.HU,
            Alpha2Code.MD,
            Alpha2Code.RS,
            Alpha2Code.UA,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new RonCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["40"];
    }
}
