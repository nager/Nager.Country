using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Gambia
    /// </summary>
    public sealed class GambiaCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Gambia";

        /// <inheritdoc/>
        public string OfficialName => "Republic of the Gambia";

        /// <inheritdoc/>
        public string NativeName => "Gambia";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.GM;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.GMB;

        /// <inheritdoc/>
        public int NumericCode => 270;

        /// <inheritdoc/>
        public string[] TLD => [".gm"];

        /// <inheritdoc/>
        public Region Region => Region.Africa;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAfrica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.SN,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new GmdCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["220"];
    }
}
