using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Uganda
    /// </summary>
    public sealed class UgandaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Uganda";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Uganda";

        /// <inheritdoc/>
        public string NativeName => "Uganda";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.UG;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.UGA;

        /// <inheritdoc/>
        public int NumericCode => 800;

        /// <inheritdoc/>
        public string[] TLD => [".ug"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.CD,
            Alpha2Code.KE,
            Alpha2Code.RW,
            Alpha2Code.SS,
            Alpha2Code.TZ,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new UgxCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["256"];
    }
}
