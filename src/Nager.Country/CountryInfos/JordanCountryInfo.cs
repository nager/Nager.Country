using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Jordan
    /// </summary>
    public sealed class JordanCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Jordan";

        /// <inheritdoc/>
        public string OfficialName => "Hashemite Kingdom of Jordan";

        /// <inheritdoc/>
        public string NativeName => "الأردن";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.JO;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.JOR;

        /// <inheritdoc/>
        public int NumericCode => 400;

        /// <inheritdoc/>
        public string[] TLD =>
        [
            ".jo",
            "الاردن."
        ];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.WesternAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.IQ,
            Alpha2Code.IL,
            Alpha2Code.PS,
            Alpha2Code.SA,
            Alpha2Code.SY,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new JodCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["962"];
    }
}
