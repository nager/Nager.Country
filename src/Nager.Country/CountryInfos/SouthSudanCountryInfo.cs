using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// South Sudan
    /// </summary>
    public sealed class SouthSudanCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "South Sudan";

        /// <inheritdoc/>
        public string OfficialName => "Republic of South Sudan";

        /// <inheritdoc/>
        public string NativeName => "South Sudan";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SS;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SSD;

        /// <inheritdoc/>
        public int NumericCode => 728;

        /// <inheritdoc/>
        public string[] TLD => [".ss"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.MiddleAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.CF,
            Alpha2Code.CD,
            Alpha2Code.ET,
            Alpha2Code.KE,
            Alpha2Code.SD,
            Alpha2Code.UG,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new SspCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["211"];
    }
}
