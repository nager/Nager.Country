using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Bangladesh
    /// </summary>
    public sealed class BangladeshCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Bangladesh";

        /// <inheritdoc/>
        public string OfficialName => "People's Republic of Bangladesh";

        /// <inheritdoc/>
        public string NativeName => "Bangladesh";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.BD;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.BGD;

        /// <inheritdoc/>
        public int NumericCode => 050;

        /// <inheritdoc/>
        public string[] TLD => [".bd"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.MM,
            Alpha2Code.IN,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [BdtCurrency.Instance];

        /// <inheritdoc/>
        public string[] CallingCodes => ["880"];
    }
}
