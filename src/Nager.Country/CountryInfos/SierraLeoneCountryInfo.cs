using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Sierra Leone
    /// </summary>
    public sealed class SierraLeoneCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Sierra Leone";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Sierra Leone";

        /// <inheritdoc/>
        public string NativeName => "Sierra Leone";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SL;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SLE;

        /// <inheritdoc/>
        public int NumericCode => 694;

        /// <inheritdoc/>
        public string[] TLD => [".sl"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.GN,
            Alpha2Code.LR,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new SllCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["232"];
    }
}
