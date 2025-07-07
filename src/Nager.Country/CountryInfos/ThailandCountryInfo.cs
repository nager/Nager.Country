using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Thailand
    /// </summary>
    public sealed class ThailandCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Thailand";

        /// <inheritdoc/>
        public string OfficialName => "Kingdom of Thailand";

        /// <inheritdoc/>
        public string NativeName => "ประเทศไทย";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TH;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.THA;

        /// <inheritdoc/>
        public int NumericCode => 764;

        /// <inheritdoc/>
        public string[] TLD => [".th", ".ไทย"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthEasternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.MM,
            Alpha2Code.KH,
            Alpha2Code.LA,
            Alpha2Code.MY,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new ThbCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["66"];
    }
}
