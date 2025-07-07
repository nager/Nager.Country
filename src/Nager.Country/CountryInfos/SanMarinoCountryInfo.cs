using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// San Marino
    /// </summary>
    public sealed class SanMarinoCountryInfo : ICountryInfo
    {
        /// <inheritdoc/>
        public string CommonName => "San Marino";

        /// <inheritdoc/>
        public string OfficialName => "Most Serene Republic of San Marino";

        /// <inheritdoc/>
        public string NativeName => "San Marino";

        /// <inheritdoc/>
        public Alpha2Code Alpha2Code => Alpha2Code.SM;

        /// <inheritdoc/>
        public Alpha3Code Alpha3Code => Alpha3Code.SMR;

        /// <inheritdoc/>
        public int NumericCode => 674;

        /// <inheritdoc/>
        public string[] TLD => [".sm"];

        /// <inheritdoc/>
        public Region Region => Region.Europe;

        /// <inheritdoc/>
        public SubRegion SubRegion => SubRegion.SouthernEurope;

        /// <inheritdoc/>
        public Alpha2Code[] BorderCountries =>
        [
            Alpha2Code.IT,
        ];

        /// <inheritdoc/>
        public ICurrency[] Currencies => [new EurCurrency()];

        /// <inheritdoc/>
        public string[] CallingCodes => ["378"];
    }
}
