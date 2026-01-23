using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guinea-Bissau
    /// </summary>
    public sealed class GuineaBissauCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Guinea-Bissau";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Guinea-Bissau";

        /// <inheritdoc/>
        public string NativeName => "Guiné-Bissau";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GW;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GNB;

        /// <inheritdoc/>
        public int NumericCode => 624;

        /// <inheritdoc/>
        public string[] TLD => [".gw"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.GN,
            Alpha2Code.SN,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [XofCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["245"];
    }
}
