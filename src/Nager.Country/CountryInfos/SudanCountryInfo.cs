using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Sudan
    /// </summary>
    public sealed class SudanCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Sudan";

        /// <inheritdoc/>
        public string OfficialName => "Republic of the Sudan";

        /// <inheritdoc/>
        public string NativeName => "السودان";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SD;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SDN;

        /// <inheritdoc/>
        public int NumericCode => 729;

        /// <inheritdoc/>
        public string[] TLD => [".sd"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.CF,
            Alpha2Code.TD,
            Alpha2Code.EG,
            Alpha2Code.ER,
            Alpha2Code.ET,
            Alpha2Code.LY,
            Alpha2Code.SS,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new SdgCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["249"];
    }
}
