using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Guinea
    /// </summary>
    public sealed class GuineaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Guinea";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Guinea";

        /// <inheritdoc/>
        public string NativeName => "Guinée";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GN;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GIN;

        /// <inheritdoc/>
        public int NumericCode => 324;

        /// <inheritdoc/>
        public string[] TLD => [".gn"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.CI,
            Alpha2Code.GW,
            Alpha2Code.LR,
            Alpha2Code.ML,
            Alpha2Code.SN,
            Alpha2Code.SL,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new GnfCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["224"];
    }
}
