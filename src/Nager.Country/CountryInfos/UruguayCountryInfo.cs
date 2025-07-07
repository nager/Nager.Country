using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Uruguay
    /// </summary>
    public sealed class UruguayCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "Uruguay";

        /// <inheritdoc/>
        public string OfficialName => "Oriental Republic of Uruguay";

        /// <inheritdoc/>
        public string NativeName => "Uruguay";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.UY;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.URY;

        /// <inheritdoc/>
        public int NumericCode => 858;

        /// <inheritdoc/>
        public string[] TLD => [".uy"];

        /// <inheritdoc/>
        public Region Region => Region.Americas;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthAmerica;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.AR,
            Alpha2Code.BR,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new UyuCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["598"];
    }
}
