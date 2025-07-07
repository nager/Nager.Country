using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Tajikistan
    /// </summary>
    public sealed class TajikistanCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Tajikistan";

        /// <inheritdoc/>
        public string OfficialName => "Republic of Tajikistan";

        /// <inheritdoc/>
        public string NativeName => "Тоҷикистон";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.TJ;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.TJK;

        /// <inheritdoc/>
        public int NumericCode => 762;

        /// <inheritdoc/>
        public string[] TLD => [".tj"];

        /// <inheritdoc/>
        public Region Region => Region.Asia;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.CentralAsia;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.AF,
            Alpha2Code.CN,
            Alpha2Code.KG,
            Alpha2Code.UZ,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new TjsCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["992"];
    }
}
