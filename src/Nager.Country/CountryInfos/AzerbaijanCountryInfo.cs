using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Azerbaijan
    /// </summary>
    public sealed class AzerbaijanCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Azerbaijan";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Azerbaijan";

        /// <inheritdoc/>
        public string NativeName => "Azərbaycan";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.AZ;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.AZE;

        /// <inheritdoc/>
        public int NumericCode => 031;

        /// <inheritdoc/>
        public string[] TLD => [".az"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.AM,
            Alpha2Code.GE,
            Alpha2Code.IR,
            Alpha2Code.RU,
            Alpha2Code.TR,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new AznCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["994"];
    }
}
