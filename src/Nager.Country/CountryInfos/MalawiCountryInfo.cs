using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Malawi
    /// </summary>
    public sealed class MalawiCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Malawi";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Malawi";

        /// <inheritdoc/>
        public string NativeName => "Malawi";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.MW;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.MWI;

        /// <inheritdoc/>
        public int NumericCode => 454;

        /// <inheritdoc/>
        public string[] TLD => [".mw"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.EasternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.MZ,
            Alpha2Code.TZ,
            Alpha2Code.ZM,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new MwkCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["265"];
    }
}
