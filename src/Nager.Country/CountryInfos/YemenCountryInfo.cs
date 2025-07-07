using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Yemen
    /// </summary>
    public sealed class YemenCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Yemen";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Yemen";

        /// <inheritdoc/>
        public string NativeName => "اليَمَن";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.YE;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.YEM;

        /// <inheritdoc/>
        public int NumericCode => 887;

        /// <inheritdoc/>
        public string[] TLD => [".ye"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.OM,
            Alpha2Code.SA,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new YerCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["967"];
    }
}
